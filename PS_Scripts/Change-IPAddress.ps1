<#
.Synopsis
    Sets a new IP address for the adapter selected
.Description
    Supports IPV4
.Notes
    Gets Adapter
    Gets Available IPs
    Gets Network Information
    Gets Parameters for Static / DHCP settings
    Gets Parameters for IPV4 or IPV6 (later on)
    returns true if successful, else false
#>
[CmdletBinding()]
param (
    [Parameter(ValueFromPipelineByPropertyName)]
    [string]
    $IP,
    [Parameter(ValueFromPipelineByPropertyName)]
    [string]
    $Mask,
    [Parameter(ValueFromPipelineByPropertyName)]
    [string]
    $Gateway,
    [Parameter(ValueFromPipelineByPropertyName)]
    [string]
    $DNS,
    [Parameter(ValueFromPipelineByPropertyName, Mandatory=$true)]
    [object]
    $Adapter,
    [Parameter(ValueFromPipelineByPropertyName, Mandatory=$true)]
    [bool]
    $IsStatic
)

try {
    if ($IsStatic) {
        $Adapter.EnableStatic($IP, $Mask)
        $Adapter.SetGateways($Gateway)
        $Adapter.SetDNSServerSearchOrder($DNS)
    } else {
        $Adapter.SetDNSServerSearchOrder()
        $Adapter.EnableDHCP()
    }
}
catch {return $false}
return $true