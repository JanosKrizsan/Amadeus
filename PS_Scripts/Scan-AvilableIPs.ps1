<#
.Synopsis
    Scans available IP addresses and retuns a given number of them
.Description
    Supports ipv4.
.Notes
    Gets parameters
    Scans for available IPs
    Returns a given number of them for usage
    Range is a list of the starting and ending numbers for the number of ips to ping
#>
[CmdletBinding()]
param (
    [Parameter(ValueFromPipelineByPropertyName)]
    [string]
    $IPV4Network,
    [Parameter(ValueFromPipelineByPropertyName)]
    [object]
    $Range
)


$CredibleAddresses = @()

$Range[0]..$Range[1] | ForEach-Object {
    $temp = "$IPV4Network.$_"
    if(!(Test-Connection $temp -Count 1 -Quiet)) {
        $CredibleAddresses += $temp
    } 
}

return $CredibleAddresses