<#
.Synopsis
    Connects to proxy server.
.Description
    Connects to a proxy server in need of authentication, via a WebRequest.
.Notes
    Overrides current proxy settings
    Clears and disables proxy upon closure
    Must run as Admin
#>

[CmdletBinding()]
param (
    [Parameter()]
    [string]
    $ProxyServer,
    [Parameter()]
    [string]
    $UserName,
    [Parameter()]
    [securestring]
    $Password
)

$Proxy = New-Object System.Net.WebProxy
$Proxy.Address = $Uri
$Proxy.Credentials = New-Object System.Net.NetworkCredential($UserName, $Password)