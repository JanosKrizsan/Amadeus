<#
.Synopsis
    Gets vpn connections
.Description
    A script for getting vpn connections
.Notes
    Get vpns
    Return needed data
#>
[CmdletBinding()]
param (
    [Parameter(ValueFromPipelineByPropertyName)]
    [string]
    $SearchTerm
)

return Get-VpnConnection | Where-Object {$_.ServerAddress -eq $SearchTerm -or $_.ServerName -eq $SearchTerm} | Format-Table