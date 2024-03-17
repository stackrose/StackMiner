﻿using System;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Principal;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Text;
using System.Resources;
using System.Threading;
using System.Diagnostics;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Management;
using System.Linq;

public partial class Checker
{
    private static void Main()
    {
        try
        {
#if DefClipper
            Console.WriteLine("Clipper Running: " + (CheckMutex("Global\\#CLIPPERID") ? "Yes" : "No"));
#endif
            bool masterRunning = CheckMutex("Global\\iGFsD9Cx4Q0qctYL");
            Console.WriteLine("Master Running: " + (masterRunning ? "Yes" : "No"));
            Console.WriteLine("Miners:");
            int miners = 0;
            string[][] minerset = new string[][] { $CHECKERSET };
            foreach (string[] miner in minerset)
            {
                if (CheckMutex("Global\\"+miner[0]))
                {
                    miners++;
                    Console.WriteLine(Encoding.Unicode.GetString(Convert.FromBase64String(miner[1])));
                }
            }

            if (miners == 0 && masterRunning)
            {
                Console.WriteLine("Master running but 0 miners detected, wait a few minutes for the master to start the miner(s).");
            }

            string _rgpu_ = "";
            Console.WriteLine("GPUs:");
            var _rconnection_ = new ConnectionOptions();
            _rconnection_.Impersonation = ImpersonationLevel.Impersonate;
            var _rscope_ = new ManagementScope("\\root\\cimv2", _rconnection_);
            _rscope_.Connect();

            var _rsearcher_ = new ManagementObjectSearcher(_rscope_, new ObjectQuery("SELECT Name, VideoProcessor FROM Win32_VideoController")).Get();
            foreach (ManagementObject _rmemObj_ in _rsearcher_)
            {
                _rgpu_ += " " + _rmemObj_["Name"];
                Console.WriteLine(" " + _rmemObj_["Name"]);
            }

            Console.WriteLine("Compatible GPU found: " + (_rgpu_.IndexOf("nvidia", StringComparison.OrdinalIgnoreCase) >= 0 || _rgpu_.IndexOf("amd", StringComparison.OrdinalIgnoreCase) >= 0));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.ToString());
        }
        Console.ReadKey();
    }

    private static bool CheckMutex(string mutex)
    {
        bool mutexActive = false;
        Mutex mutexObj = null;

        try
        {
            mutexObj = Mutex.OpenExisting(mutex);
            mutexActive = true;
        }
        catch (WaitHandleCannotBeOpenedException) { }
        catch (UnauthorizedAccessException)
        {
            mutexActive = true;
        }
        if (mutexObj != null) mutexObj.Close();
        return mutexActive;
    }
}