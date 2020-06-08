<#
.Synopsis
    Forces admin execution on scripts where needed.
.Description
    Same as synopsis.
.Notes
    Checks if Admin
    If not, elevates session to Admin
#>
[CmdletBinding()]
param (
    [Parameter()]
    [string]
    $ExecScriptPath,
    [Parameter()]
    [string]
    $ArgumentsForScript
)

$CurrentID = [System.Security.Principal.WindowsIdentity]::GetCurrent()
$CurrentPrincipal = New-Object System.Security.Principal.WindowsPrincipal($CurrentID)
$AdminRole = [System.Security.Principal.WindowsBuiltInRole]::Administrator

if (!$CurrentPrincipal.IsInRole($AdminRole)) {
    Start-Process PowerShell -Verb RunAs -ArgumentList "& $ExecScriptPath $ArgumentsForScript"
    exit
}

Invoke-Expression "$ExecScriptPath $ArgumentsForScript"
exit


