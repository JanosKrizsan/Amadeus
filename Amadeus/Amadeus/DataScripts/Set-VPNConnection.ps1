<#
.Synopsis
    Sets existing vpn connection details
.Description
    A script for updating vpn connections
.Notes
    Get parameters
    Set vpn
    If successful, return true, else false
#>
[CmdletBinding()]
param (
    [Parameter(ValueFromPipelineByPropertyName)][string]$Name,
    [Parameter(ValueFromPipelineByPropertyName)][string]$Address,
    [Parameter(ValueFromPipelineByPropertyName)][string]$TunnelType,
    [Parameter(ValueFromPipelineByPropertyName)][string]$EncryptionLvl,
    [Parameter(ValueFromPipelineByPropertyName)][string]$AuthMethod,
    [Parameter(ValueFromPipelineByPropertyName)][bool]$SplitTunnel,
    [Parameter(ValueFromPipelineByPropertyName)][bool]$AllUsersAvail
)

if (!$Name -and !$Address) {
    return $false;
} else {
    $SearchBy = if (!$Address) {$Name} else {$Address}
    $VPN = .\Get-VPNs.ps1 -SearchTerm $SearchBy

    $NewName = if ($Name) {"-Name $Name"} else {$Name}
    $NewAdd = if ($Address) {"-ServerAddress $Address"} else {$Address}
    $NewTunnel = if ($TunnelType) {"-TunnelType $TunnelType"} else {$TunnelType}
    $NewEncrypt = if ($EncryptionLvl) {"-EncryptionLevel $EncryptionLvl"} else {$EncryptionLvl}
    $NewAuth = if ($AuthMethod) {"-AuthenticationMethod $AuthMethod"} else {$AuthMethod}
    $NewSplit = if ($SplitTunnel) {"-SplitTunneling $SplitTunnel"} else {$SplitTunnel}
    $NewAvail = if ($AllUsersAvail) {"-AllUserConnection $AllUserAvail"} else {$AllUsersAvail}

    $Variables = "$NewName $NewAdd $NewTunnel $NewEncrypt $NewAuth $NewSplit $NewAvail"

    $Expression = "$VPN | Set-VpnConnection $Variables"
    
    try {Invoke-Expression $Expression}
    catch {return $false}
    return $true;
}