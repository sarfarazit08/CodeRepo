
$resourceGroup = "psod-iaas-m3"
$location = "North Europe"
New-AzureRmResourceGroup -Name $resourceGroup -Location $location

$storageAccountName = "psodiaasm3"
New-AzureRmStorageAccount -Name $storageAccountName -ResourceGroupName $resourceGroup `
                          -Type Standard_LRS -Location $location

$vnetName = "iaas-vnet" 
$vnet = New-AzureRmVirtualNetwork -Name $vnetName -ResourceGroupName $resourceGroup -Location $location -AddressPrefix 10.0.0.0/16

$internalLbName = "iaas-lb-internal"

. .\m3-create-subnet-internal.ps1 -ResourceGroupName $resourceGroup -Location $location `
                                  -VnetName $vnetName -SubnetIndex 0 `
                                  -LoadBalancerName $internalLbName -AddressPrefix 10.0.1.0/24

$aSetInternal = New-AzureRmAvailabilitySet -ResourceGroupName $resourceGroup -Location $location `
                                           -Name "iaas-aset-internal"

For ($i=0; $i -lt 3; $i++) {

    . .\m3-create-windows-vm.ps1 -ResourceGroupName $resourceGroup -Location $location `
                                 -StorageAccountName $storageAccountName -VmName "win-web-$i" `
                                 -VnetName $vnetName -SubnetIndex 0 `
                                 -AvailabilitySetId $aSetInternal.Id -LoadBalancerName $internalLbName
}

$publicLbName = "iaas-lb-public"

. .\m3-create-subnet-public.ps1 -ResourceGroupName $resourceGroup -Location $location `
                                -VnetName $vnetName -SubnetIndex 1 `
                                -LoadBalancerName $publicLbName -AddressPrefix 10.0.2.0/24

$aSetPublic = New-AzureRmAvailabilitySet -ResourceGroupName $resourceGroup -Location $location `
                                         -Name "iaas-aset-public"

For ($i=0; $i -lt 2; $i++) {

    . .\m3-create-linux-vm.ps1 -ResourceGroupName $resourceGroup -Location $location `
                               -StorageAccountName $storageAccountName -VmName "ub-proxy-$i" `
                               -VnetName $vnetName -SubnetIndex 1 `
                               -AvailabilitySetId $aSetPublic.Id -LoadBalancerName $publicLbName
}

