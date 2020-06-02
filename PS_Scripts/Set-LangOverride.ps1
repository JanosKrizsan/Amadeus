<#
.Synopsis
    Sets override language, and also adds it if it is not present already
.Description
    A script for setting windows language. Requires logging out
.Notes
    Get languages
    Check if part, if not add
    Set language
#>
[CmdletBinding()]
param (
    [Parameter(ValueFromPipelineByPropertyName)]
    [string]
    $LanguageTag
)

$Languages = .\Get-Languages.ps1
$Contians = $false
foreach ($lang in $Languages) {
    if ($lang[0] -eq $LanguageTag) {
        $Contians = $true
    }
}

if (!$Contians) {
    .\Add-WindowsLanguage.ps1 -LanguageTag $LanguageTag
}

Set-WinUILanguageOverride -Language $LanguageTag
logoff.exe