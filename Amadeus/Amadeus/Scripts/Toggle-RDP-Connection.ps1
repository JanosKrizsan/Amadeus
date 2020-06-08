<#
.Synopsis
    Logs into RDP.
.Description
    Same as synopsis.
    https://winaero.com/blog/mstsc-exe-command-line-arguments/
.Notes
    Logs in to RDP with the provided settings and credentials
#>
[CmdletBinding()]
param (
    [Parameter(ValueFromPipelineByPropertyName)]
    [securestring]
    $SettingsWithCreds
)

Start-Process "$env:windir\system32\mstsc.exe" -ArgumentList "$SettingsWithCreds"