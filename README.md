# MVP

![Passport](https://imgur.com/Wrgy0jA.jpg)

## What is this

A C# WinForms app that could use the PS scripts included. Partial implementation, this is a project to showcase a possible WinForms MVP structure.
This showcase-project is now deemed finished by the author.

## Tech Used
- PS
- C#
- WinForms

## Structure

### PS Scripts
These are ran via C#:<br>
The C# desktop app runs various PS scripts to change states, connect to services and apply changes to the environment.
- Connect to VPN 
- Connect to Proxy
- Connect to RDP
- Spoof Mac Address
- Change Sys Language
- Change IP

Additional:<br>
- Force scripts to run in elevated mode
- Notification of system language and location language
- Password choices, encrypted saving
- PS scripts are protected

### C# Core
- Transfers and uses data
- Encrypts and saves user data
- Sends e-mail of reports
- Runs PS scripts
- Error Handling via C#

### WinForms
- Understanding is 80% of the battle here
- Refactored Designer code

#### Windows
Login / Register:<br>
- Adds users
- Logs in to Main Menu

Main Menu:<br>
- Is a hub for the rest of the windows
- Textbox provides updates of operation
- Current operation status is shown below textbox
- Scripts can be run, added and removed (except basic ones)
- Current operation can be stopped
- Reports can be saved to XML, CSV or simple Text file
- Current report can be wiped and reset
- Windows that can be opened are:
  - Options
  - VPN
  - Proxy
  - RDP
  - MAC
  - IP
  
Settings:<br>
- Setting up User Data to be saved, deleted, we can add users here if we are an admin
- Setting up operational mechanisms
- Setting up e-mail to send to, can enforce e-mail PGP encryption


Negatives so far:<br>
- Will be a lot of code-deletion later, because some of the auto-generated will not be needed.
- My design skills.

Positives:<br>
- Comfy editor.
- Straightforward generated code
- Not that different from WPF

Note: I could structure it within a tab controller but I'm not really sure that would be the best application-design for this. It might become too beefy due to that and less clear.

## Development and Testing

### Development
 - In VS Community and VS Code
 - Separation of parts in Version Control
 - Refactoring of the designer generated code
 
 Note:<br>
 The refactoring the designer generated code is not advised normally, as it might cause non-errors to appear. Either better to write the WinForms code yourself, or rely on the designer to do so.
 
### Testing
 - Will either need a VM or an RDP to test the scripts without rendering your computer useless

## Resources / Info / Documentation

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
[Cmdlet Writing](https://docs.microsoft.com/en-us/powershell/scripting/developer/cmdlet/how-to-write-a-simple-cmdlet?view=powershell-7)

### WinForms
[Possible Way to Access Control](https://stackoverflow.com/questions/12903489/is-it-allowed-to-change-code-in-windows-form-designer-generated-code-designer)<br>
[Winforms Structure Hints](https://softwareengineering.stackexchange.com/questions/144423/how-to-properly-structure-a-project-in-winform)<br>
[Generated Code](https://www.codeproject.com/Articles/6020/What-s-that-quot-Windows-Form-Designer-generated-c)<br>
[MVVM](https://softwareengineering.stackexchange.com/questions/277143/how-do-you-separate-view-from-logic-in-a-winform-application)<br>
[General Practices](https://markheath.net/post/maintainable-winforms)<br>
[Best Practices](https://bettersolutions.com/csharp/windows-forms/best-practies.htm)<br>
[Custom Controls](https://www.akadia.com/services/dotnet_user_controls.html)<br>
[Winforms Tutorial](https://riptutorial.com/winforms)
[MVP](https://stackoverflow.com/questions/4794121/model-view-presenter-in-winforms)<br>
[More MVP](https://www.codeproject.com/Articles/14660/WinForms-Model-View-Presenter)<br>
[MVP Example](https://codereview.stackexchange.com/questions/131330/model-view-presenter-winforms-app)
[MVP MVC](https://stackoverflow.com/questions/2056/what-are-mvp-and-mvc-and-what-is-the-difference)
[Winforms Controls](https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/overview-of-using-controls-in-windows-forms)<br>
[MVP Video Series](https://www.youtube.com/watch?v=XHw4bBLM8Vk&list=WL&index=12)


### PGP

[PGP File Encryption](https://www.codeproject.com/Questions/69856/Encrypting-and-Decrypting-files-with-PGP-and-C)<br>
[More File Encryption](https://stackoverflow.com/questions/4192296/c-sharp-how-to-simply-encrypt-a-text-file-with-a-pgp-public-key)<br>
[In General](https://www.codeproject.com/Articles/457453/PGP-Encryption-with-Csharp)<br>


### .NET

[Secure String](https://docs.microsoft.com/en-us/dotnet/api/system.security.securestring?view=netcore-3.1)<br>
[Secure String in C#](https://blog.thedigitalgroup.com/usability-of-securestring-object-in-c)<br>
[Encrypting Data](https://www.codeproject.com/Articles/14150/Encrypt-and-Decrypt-Data-with-C)<br>
[Encrypting Files](https://www.codeproject.com/Articles/20564/Encrypt-Decrypt-File-or-String)<br>
[AES Encryptiong](https://www.c-sharpcorner.com/article/aes-encryption-in-c-sharp/)<br>
[Zip Files](https://stackoverflow.com/questions/13160490/decompressing-password-protected-zip-files-with-net-4-5)<br>
[Zip Files C#](https://www.c-sharpcorner.com/UploadFile/neill1212/password-encrypted-zip-files-in-C-Sharp/)<br>
[Class or Struct](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/choosing-between-class-and-struct)
