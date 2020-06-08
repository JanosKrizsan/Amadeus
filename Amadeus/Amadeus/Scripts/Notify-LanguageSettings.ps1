<#
.Synopsis
    Notifies of the current language settings and geolocation match
.Description
    Same as synopsis
.Notes
    Gets geolocations
    Gets current language
    returns if they match or not
#>

$Country = .\Get-Geolocation.ps1.country
$CurrentLang = Get-WinSystemLocale | Select-Object DisplayName

return "Your current country is $Country and your system language is $CurrentLang"