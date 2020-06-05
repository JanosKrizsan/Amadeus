<#
.Synopsis
    Gets IP addresses for the selected adapter.
.Description
    Gets adapter's IPV6 and IPV4 addresses (if applicable)
.Notes
    Gets adapter parameter
    Gets IP addresses associated with adapter.
#>
[CmdletBinding()]
param (
    [Parameter(ValueFromPipelineByPropertyName)]
    [object]
    $NetAdapter
)

$OSInfo = (Get-WmiObject Win32_OperatingSystem).Name 
$IsNewerOs = $OsInfo -match '8' -or $OsInfo -match '10'
if ($IsNewerOs) {
    $IPs = $NetAdapter | Get-NetIPAddress | Select-Object -Property IPAddress | ForEach-Object {"$($_.IPAddress)"}
} else {
    $NetAdapter = $NetAdapter.ifDesc
    $IPs = Get-WmiObject Win32_NetworkAdapterConfiguration -Filter "Description = '$NetAdapter'"
}

#$CurrentNetWInf = Get-WmiObject Win32_NetworkAdapterConfiguration | Where-Object IpEnabled | Select-Object -Property IPSubnet, IPAddress

return $IPs