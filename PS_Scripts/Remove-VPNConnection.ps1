<#
.Synopsis
    Removes a new vpn connection
.Description
    A script for removing vpn connections from windows.
.Notes
    Get parameters
    remove vpn
    If successful, return true, else false
#>

[CmdletBinding()]
param (
    [Parameter(ValueFromPipelineByPropertyName)]
    [string]
    $Name,
    [Parameter(ValueFromPipelineByPropertyName)]
    [string]
    $Address
)
$SearchBy = if (!$Address) {$Name} else {$Address}
$VPNs = .\Get-VPNs.ps1 -SearchTerm $SearchBy

try {$VPNs | Remove-VpnConnection}
catch {return $false}
return $true