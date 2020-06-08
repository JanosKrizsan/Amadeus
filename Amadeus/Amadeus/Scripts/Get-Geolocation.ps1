<#
.Synopsis
    Gets geolocation of the current computer
.Description
    Same as synopsis
.Notes
    Sends a get-method
    Returns the results as an object
    Internet access is required
#>

return Invoke-RestMethod -Uri "ipinfo.io" -Method Get | Select-Object City, Region, Country, loc
