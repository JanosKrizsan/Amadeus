<#
.Synopsis
    Adds a new vpn connection
.Description
    A script for adding vpn connections to windows.
.Notes
    Get parameters
    Add vpn
    If successful, return true, else false
#>
[CmdletBinding()]
param (
    [Parameter(ValueFromPipelineByPropertyName,Mandatory=$true)][string]$Name,
    [Parameter(ValueFromPipelineByPropertyName,Mandatory=$true)][string]$Address,
    [Parameter(ValueFromPipelineByPropertyName)][string]$TunnelType,
    [Parameter(ValueFromPipelineByPropertyName)][string]$EncryptionLvl,
    [Parameter(ValueFromPipelineByPropertyName)][string]$AuthMethod,
    [Parameter(ValueFromPipelineByPropertyName,Mandatory=$true)][bool]$SplitTunnel,
    [Parameter(ValueFromPipelineByPropertyName,Mandatory=$true)][bool]$AllUsersAvail
)

function Is-Present {
    param (
        [Parameter()]
        [string]
        $Type,
        [Parameter()]
        [string]
        $Var
    )
    return if ($Var) {"-$type $Var"} else {""}
}

$Optionals = "$(Is-Present('TunnelType', $TunnelType)) $(Is-Present('EncryptionLevel', $EncryptionLvl)) $(Is-Present('AuthenticationMethod', $AuthMethod))"
$Split = if ($SplitTunnel) {"-SplitTunneling"} else {""}
$AllUser = if ($AllUsersAvail) {"-AllUserConnection"} else {""}
$Expression = "Add-VpnConnection -Name $Name -ServerAddress $Address $Optionals $Split $AllUser"

try {Invoke-Expression $Expression}
catch {return $false}
return $true
