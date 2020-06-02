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
    $LanguageTag
)

$Current = .\Get-Languages.ps1

if ($LanguageTag.Length -eq 5 -and $LanguageTag -match "[a-z]{2}-[A-Z]{2}") {
    $Current.Add($LanguageTag)

    try {Set-WinUserLanguageList -LanguageList $Current}
    catch {return $false}
    return $true
}

