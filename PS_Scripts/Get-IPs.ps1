<#
.Synopsis
    Gets and sets IP address.
.Description
    A script for setting the IP address of the selected adapter.
.Notes
    Retrieve the Adapter IPs
    Remove settings
    Add new settings to the adapter
    Returns original settings to executing C# program
#>

[CmdletBinding()]
param (
    [Parameter()]
    [string]
    $AdapterName,
    [Parameter()]
    [bool]
    $isStatic
)

$AdapterConfig = Get-WmiObject -Class Win32_NetworkAdapterConfiguration -Filter IPEnabled=$true -ComputerName. | Where-Object {$_.Description -ilike "*$AdapterName*"}

if ($isStatic) {
    
}