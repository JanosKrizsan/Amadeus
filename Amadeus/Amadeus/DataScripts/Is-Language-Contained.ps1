<#
.Synopsis
    Checks if the requested language is included already.
.Description
    A script for checking languages included
.Notes
    Checks if language is already present.
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
        break
    }
}

return $Contians