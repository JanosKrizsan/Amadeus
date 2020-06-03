<#
.Synopsis
    Adds a new language to the list
.Description
    A script for adding a new language to windows
.Notes
    Gets the name and adds a new language. Must be in the correct format.
#>
[CmdletBinding()]
param (
    [Parameter(ValueFromPipelineByPropertyName)]
    [string]
    $LanguageTag,
    [Parameter(ValueFromPipelineByPropertyName)]
    [bool]
    $IsDeleting
)

$SysLang = Get-WinSystemLocale | Select-Object -Property Name 
$Current = .\Get-Languages.ps1
$IsSysLang = $SysLang -eq $LanguageTag
$Contains = .\Is-Language-Contained.ps1 -LanguageTag $LanguageTag

if ($IsDeleting -and !$IsSysLang) {
    $Current.Remove($LanguageTag)
} elseif (!$IsDeleting -and !$Contains) {
    $Current.Add($LanguageTag)
} else {
    return $false
}

try {Set-WinUserLanguageList -LanguageList $Current}
catch {return $false}
return $true


