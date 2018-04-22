$resourceGroup = "psod-iaas-m3v2"
$location = "North Europe"
$vnetName = "iaas-vnet"
$subnetName = "iaas-lb-public-backend"

$allow80In = New-AzureRmNetworkSecurityRuleConfig `
                  -Name 'Allow-HTTP-In' `
                  -Description 'Allow-HTTP-In' `
                  -Access Allow `
                  -Protocol 'TCP' `
                  -Direction Inbound `
                  -Priority 100 `
                  -SourceAddressPrefix Internet `
                  -SourcePortRange * `
                  -DestinationAddressPrefix * `
                  -DestinationPortRange 80

$denyAllOut = New-AzureRmNetworkSecurityRuleConfig `
        -Name 'Deny-Outbound' `
        -Description 'Deny-Outbound' `
        -Access Deny `
        -Protocol * `
        -Direction Outbound `
        -Priority 500 `
        -SourceAddressPrefix VirtualNetwork `
        -SourcePortRange * `
        -DestinationAddressPrefix Internet `
        -DestinationPortRange *


$publicNsg = New-AzureRmNetworkSecurityGroup `
                        -Name 'Public-NSG' `
                        -ResourceGroupName $resourceGroup `
                        -Location $location `
                        -SecurityRules $allow80In, $denyAllOut

$vnet = Get-AzureRmVirtualNetwork -ResourceGroupName $resourceGroup -Name $vnetName

Set-AzureRmVirtualNetworkSubnetConfig -VirtualNetwork $vnet -Name $subnetName `
                                      -AddressPrefix 10.0.2.0/24 -NetworkSecurityGroup $publicNsg

Set-AzureRmVirtualNetwork -VirtualNetwork $vnet