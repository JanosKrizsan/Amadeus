<#
.Synopsis
    Generates hex values for a new Mac address.
.Description
    A script used to generate a randomized Mac address to be used elsewhere.
.Notes
    Takes a base value as string
    Generates 6 random hex pairs
    Appends and returns full address generated
    Admin access needed.
#>

[CmdletBinding()]
param (
    [Parameter(ValueFromPipeline, Mandatory=$true)]
    [string]
    $AddressBase
)

function Get-Random-Num {
    return Get-Random -Minimum 0 -Maximum 15
}

function Convert-DecToHex {
    return [System.Convert]::ToString((Get-Random-Num), 16).ToUpper()
}

function Get-Random-Pair {
    return @((Convert-DecToHex), (Convert-DecToHex))
}

function Get-Last-Pairs {
    $LastDigits = ""
    while ($LastDigits.Length -le 8 ) {
        Write-Host $LastDigits
        $digits = Get-Random-Pair
        Write-Host $digits
        $digits = "{0}{1}" -f $digits[0], $digits[1]
        $LastDigits = "$LastDigits-$digits"
    }
    return $LastDigits
}

function Get-FinalAddress {
    return "$AddressBase$(Get-Last-Pairs)"
}

return Get-FinalAddress