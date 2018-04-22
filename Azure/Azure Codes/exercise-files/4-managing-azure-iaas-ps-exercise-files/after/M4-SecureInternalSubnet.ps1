$resourceGroup = "psod-iaas-m3v2"
$location = "North Europe"
$vnetName = "iaas-vnet"
$subnetName = "iaas-lb-internal-backend"

$allow8080In = New-AzureRmNetworkSecurityRuleConfig `
                  -Name 'Allow-Proxy-In' `
                  -Description 'Allow-Proxy-In' `
                  -Access Allow `
                  -Protocol 'TCP' `
                  -Direction Inbound `
                  -Priority 100 `
                  -SourceAddressPrefix 10.0.2.0/24 `
                  -SourcePortRange * `
                  -DestinationAddressPrefix * `
                  -DestinationPortRange 8080

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

$internalNsg = New-AzureRmNetworkSecurityGroup `
                        -Name 'Internal-NSG' `
                        -ResourceGroupName $resourceGroup `
                        -Location $location `
                        -SecurityRules $allow80In, $denyAllOut

$vnet = Get-AzureRmVirtualNetwork -ResourceGroupName $resourceGroup -Name $vnetName

Set-AzureRmVirtualNetworkSubnetConfig -VirtualNetwork $vnet -Name $subnetName `
                                      -AddressPrefix 10.0.1.0/24 -NetworkSecurityGroup $null

Set-AzureRmVirtualNetwork -VirtualNetwork $vnet