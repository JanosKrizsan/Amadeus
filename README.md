# Amadeus

![Passport](https://imgur.com/Wrgy0jA.jpg)

## What is this

A handy tool to access anonimizing settings within the Win. Environment.

## Tech Used
- PS
- C#
- C++ (maybe)
- WinForms

## Structure and Features

### PS Scripts
These are ran via C#:<br>
The C# desktop app runs various PS scripts to change states, connect to services and apply changes to the environment.
- Connect to VPN 🟢
- Connect to Proxy 🟢
- Connect to RDP 🟢
- Spoof Mac Address 🟢
- Change Sys Language 🟢
- Change IP 🟢

Additional:<br>
- Force scripts to run in elevated mode 🟢
- Notification of system language and location language 🟢
- Password choices, encrypted saving
- PS scripts are protected

### C# Core
- Transfers and uses data
- Runs PS scripts
- Error Handling and all that good stuff

### WinForms
- Understanding is 80% of the battle here

## Usage

1. Download the release and run the executable as Administrator
2. Check Whoer.net to see your changes
3. Be happy and rejoice

This readme will be updated consistently.

## Resources / Info

### PS Networking
[VPN Protocols](https://proprivacy.com/vpn/guides/vpn-encryption-the-complete-guide#vpn-encryption-protocols)<br>
[Set IP Basics](https://mcpmag.com/articles/2018/02/28/set-ip-address-with-powershell.aspx)<br>
[Set IP In-Depth](http://itproguru.com/expert/2012/01/using-powershell-to-get-or-set-networkadapterconfiguration-view-and-change-network-settings-including-dhcp-dns-ip-address-and-more-dynamic-and-static-step-by-step/)<br>
[Set Static & DHCP Part 1](https://www.pdq.com/blog/using-powershell-to-set-static-and-dhcp-ip-addresses-part-1/)<br>
[Set Static & DHCP Part 2](https://www.pdq.com/blog/using-powershell-to-set-static-and-dhcp-ip-addresses-part-2/)<br>
[IP Spoofing is Hard](https://www.codeproject.com/articles/800872/spoofing-an-ip-is-hard)<br>
[WMI](https://en.wikipedia.org/wiki/Windows_Management_Instrumentation)<br>
[Powershell Operators](https://www.tutorialspoint.com/powershell/powershell_operators.htm)<br>
[IPV4](https://docs.oracle.com/cd/E19683-01/806-4075/ipref-1/index.htmlhttps://docs.oracle.com/cd/E19253-01/816-4554/ipv6-overview-123/index.html)<br>
[IPV6](https://docs.oracle.com/cd/E19253-01/816-4554/ipv6-overview-123/index.html)<br>
[Powershell Sweeps](https://devblogs.microsoft.com/scripting/use-powershell-for-network-host-and-port-discovery-sweeps/)<br>

### WinForms
[Possible Way to Access Control](https://stackoverflow.com/questions/12903489/is-it-allowed-to-change-code-in-windows-form-designer-generated-code-designer)<br>
[Generated Code](https://www.codeproject.com/Articles/6020/What-s-that-quot-Windows-Form-Designer-generated-c)<br>
[MVVM](https://softwareengineering.stackexchange.com/questions/277143/how-do-you-separate-view-from-logic-in-a-winform-application)<br>
[General Practices](https://markheath.net/post/maintainable-winforms)<br>
[Best Practices](https://bettersolutions.com/csharp/windows-forms/index.htm)<br>
[Custom Controls](https://www.akadia.com/services/dotnet_user_controls.html)
