<#
.Synopsis
    Adds an app trigger to vpn connection.
.Description
    A script that adds an application trigger to start up a specific vpn connection, upon the launch of said application.
.Notes
    Get vpn name, get app name
    returns true if successful
#>
[CmdletBinding()]
param (
    [Parameter(ValueFromPipelineByPropertyName)][string]$VpnName,
    [Parameter(ValueFromPipelineByPropertyName)][string]$AppName,
    [Parameter(ValueFromPipelineByPropertyName, Mandatory=$true)][bool]$ToggleAdd
)

$ExpBody = "-Name $VpnName -ApplicationID $AppName"
$Func = if ($ToggleAdd) {"Add-VpnConnectionTriggerApplication"} else {"Remove-VpnConnectionTriggerApplication"}
try {Invoke-Expression "$Func $ExpBody"}
catch {return $false}
return $true;

    