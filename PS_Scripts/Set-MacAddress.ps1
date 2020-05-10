<#
.Synopsis
    Sets or resets Mac Address of target Adapter.
.Description
    A script used to set and reset the MAC address of the current system.
    If no Target Adapter is provided, it finds the first connected one and changes the Mac of that.
.Notes
    Retrieve adapters
    Save current address of soon to be changed adapter
    Pass original back to parent process
    Admin access needed
#>
[CmdletBinding()]
param (
    [Parameter(ValueFromPipelineByPropertyName)]
    [string]$AdapterName,
    [Parameter(ValueFromPipelineByPropertyName)]
    [string]$NewMac,
    [Parameter(ValueFromPipelineByPropertyName, Mandatory=$true)]
    [bool]$IsReset
)

function Get-Adapter-Info {
    [CmdletBinding()]
    param([Parameter(ValueFromPipeline)]$Ads)
    return $Ads | Select-Object Name, InterfaceDescription, MacAddress, MediaConnectionState | Format-List
}

function Find-Correct-Adapter {
    [Cmdletbinding()]
    param(
        [Parameter(ValueFromPipeline)]$Infos
    )
    return $Infos | Where-Object MediaConnectionState -eq Connected | Select-Object -First
}

function Set-Adapter-Mac {
    [CmdletBinding()]
    param(
        [Parameter(ValueFromPipeline, Mandatory=$true)]$Target
    )
    $Target | Set-NetAdapter -MacAddress $NewMac
    if ($IsReset) {return $true}
}

$Adapters = if (!$AdapterName) {Get-NetAdapter} else {Get-NetAdapter | Where-Object InterfaceDescription -ilike "*$AdapterName*"}

switch ($IsReset) {
    $false { 
        $AdapterInfo = $Adapters | Get-Adapter-Info | Find-Correct-Adapter
        $AdapterInfo | Set-Adapter-Mac
        
        return $AdapterInfo
     }
    Default {
        return $Adapters | Set-Adapter-Mac
    }
}


