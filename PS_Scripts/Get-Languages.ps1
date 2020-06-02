<#
.Synopsis
    Gets currently used languages.
.Description
    A script for getting current windows languages installed.
.Notes
    Gets and returns languages.
#>

$LanguageInfos = Get-WinUserLanguageList
$SortedLangs = New-Object -TypeName "System.Collections.ArrayList"

$LanguageInfos | ForEach-Object -Process {$SortedLangs.Add(@($_.LanguageTag, $_.EnglishName, $_.ScriptName))}

return $SortedLangs