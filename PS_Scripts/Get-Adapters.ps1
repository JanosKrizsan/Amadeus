<#
.Synopsis
    Gets and Filters adapters.
.Description
    Gets the adapters, then filters them. Filters out VPNs, LAN connections.
    Also only returns currently enabled / connected adapters.
.Notes
    Gets adapters
    Filters adapters
    Returns compatible adapters
#>
[CmdletBinding()]
param (
    [Parameter(ValueFromPipelineByPropertyName)]
    [bool]
    $ReturnAll
)

$ExcludedProps = "ComputerName, NetCompartment.CompartmentId, NetCompartment.CompartmentDescription"
$ExcludeStatus = ", Netadapter.Status"
$SelectItems = if ($ReturnAll) {$ExcludedProps} else {"$Excludedprops$ExcludeStatus"}

switch ($ReturnAll) {
    $true {
        return Get-NetAdapter | Get-NetIPConfiguration -Detailed | Select-Object -ExcludeProperty $SelectItems
    }
    default {
        return Get-NetAdapter | Where-Object {$_.Status -eq "Up"} | Get-NetIPConfiguration -Detailed | Select-Object -ExcludeProperty $SelectItems$
    }
}

#Get-WmiObject -Class Win32_NetworkAdapter -Filter "netconnectionstatus = 2 "
