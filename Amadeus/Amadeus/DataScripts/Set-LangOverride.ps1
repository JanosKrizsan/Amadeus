<#
.Synopsis
    Sets override language, and also adds it if it is not present in language list already
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

$Contains = .\Is-Language-Contained.ps1 -LanguageTag $LanguageTag

if (!$Contains) {
    .\AddOrRemove-WindowsLanguage.ps1 -LanguageTag $LanguageTag -IsDeleting $false
}

Set-WinUILanguageOverride -Language $LanguageTag
logoff.exe