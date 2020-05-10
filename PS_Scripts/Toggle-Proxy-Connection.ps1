<#
.Synopsis
    Sets and resets current proxy settings.
.Description
    Sets and / or resets current proxy settings by editing the relevant registry.
    Should be able to set proxy as one which needs authentication from the User.
.Notes
    Overrides current proxy settings
    Clears and disables proxy upon closure
    Must run as Admin
#>
[CmdletBinding()]
param (
    [Parameter(ValueFromPipelineByPropertyName)]
    [string]
    $ProxyServer,
    [Parameter(ValueFromPipelineByPropertyName)]
    [string]
    $UserName,
    [Parameter(ValueFromPipelineByPropertyName)]
    [securestring]
    $Password,
    [Parameter(ValueFromPipelineByPropertyName, Mandatory=$true)]
    [bool]
    $IsAuthProxy,
    [Parameter(ValueFromPipelineByPropertyName, Mandatory=$true)]
    [bool]
    $IsFlush
)

$RegLocation = "HKCU:\Software\Microsoft\Windows\CurrentVersion\Internet Settings"
$ToggleProxyScript = { 
    param (
        [Parameter(Position=0)]
        $RegEntry,
        [Parameter(Position=1)]
        $Value
    )
    Set-ItemProperty -Path $RegLocation -Name $RegEntry -Value $val 
}

function Enable-Proxy {
    Invoke-Command -ScriptBlock $ToggleProxyScript -ArgumentList ProxyEnable, 1
}

function Disable-Proxy {
    Invoke-Command -ScriptBlock $ToggleProxyScript -ArgumentList ProxyEnable, 0
}

function Set-Proxy {
    if ($IsAuthProxy){
        $Proxy = New-Object System.Net.WebProxy
        $Proxy.Address = $ProxyServer
        $Proxy.Credentials = New-Object System.Net.NetworkCredential($UserName, $Password)
    }
    Invoke-Command -ScriptBlock $ToggleProxyScript -ArgumentList ProxyServer ,$ProxyServer
}

function Clear-Proxy {
    Clear-ItemProperty -Path $RegLocation -Name ProxyServer
}

switch ($IsFlush) {
    $true {
        Set-Proxy
        Enable-Proxy
        return "Connected to proxy."
    }
    Default {
        Disable-Proxy
        Clear-Proxy
        return "Flushed proxy settings."
    }
}