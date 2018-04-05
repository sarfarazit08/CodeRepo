$resourceGroup = "psod-iaas"
$location = "North Europe"

New-AzureRmResourceGroup -Name $resourceGroup -Location $location

$storageAccountName = "psodiaas"
New-AzureRmStorageAccount -Name $storageAccountName -ResourceGroupName $resourceGroup `
                          -Type Standard_LRS -Location $location

$vnetName = "iaas-net" 
$subnet=New-AzureRmVirtualNetworkSubnetConfig -Name frontendSubnet -AddressPrefix 10.0.1.0/24
$vnet = New-AzureRmVirtualNetwork -Name $vnetName -ResourceGroupName $resourceGroup -Location $location `
                                  -AddressPrefix 10.0.0.0/16 -Subnet $subnet

#Windows Server
$nicName="vm1-nic"
$pip = New-AzureRmPublicIpAddress -Name $nicName -ResourceGroupName $resourceGroup `
                                  -Location $location -AllocationMethod Dynamic
$nic = New-AzureRmNetworkInterface -Name $nicName -ResourceGroupName $resourceGroup `
                                   -Location $location -SubnetId $vnet.Subnets[0].Id -PublicIpAddressId $pip.Id

$vmName = "win-web"
$vm = New-AzureRmVMConfig -VMName $vmName -VMSize "Basic_A1"

$cred=Get-Credential -Message "Admin credentials"
$vm=Set-AzureRmVMOperatingSystem -VM $vm -Windows -ComputerName $vmName -Credential $cred `
                                 -ProvisionVMAgent -EnableAutoUpdate
$vm=Set-AzureRmVMSourceImage -VM $vm -PublisherName "MicrosoftWindowsServer" `
                             -Offer "WindowsServer" -Skus "2012-R2-Datacenter" -Version "latest"

$vm=Add-AzureRmVMNetworkInterface -VM $vm -Id $nic.Id

$diskName="os-disk"
$storageAcc=Get-AzureRmStorageAccount -ResourceGroupName $resourceGroup -Name $storageAccountName
$osDiskUri=$storageAcc.PrimaryEndpoints.Blob.ToString() + "vhds/" + $diskName  + ".vhd"
$vm=Set-AzureRmVMOSDisk -VM $vm -Name $diskName -VhdUri $osDiskUri -CreateOption fromImage

New-AzureRmVM -ResourceGroupName $resourceGroup -Location $location -VM $vm


#Linux Server
$nic2Name="vm2-nic"
$pip2 = New-AzureRmPublicIpAddress -Name $nic2Name -ResourceGroupName $resourceGroup `
                                   -Location $location -AllocationMethod Dynamic
$nic2 = New-AzureRmNetworkInterface -Name $nic2Name -ResourceGroupName $resourceGroup `
                                    -Location $location -SubnetId $vnet.Subnets[0].Id -PublicIpAddressId $pip2.Id

$vm2Name = "ub-proxy"
$vm2 = New-AzureRmVMConfig -VMName $vm2Name -VMSize "Basic_A1"

$cred2=Get-Credential -Message "Admin credentials"
$vm2=Set-AzureRmVMOperatingSystem -VM $vm2 -Linux  -ComputerName $vm2Name -Credential $cred2 
$vm2=Set-AzureRmVMSourceImage -VM $vm2 -PublisherName "Canonical" `
                             -Offer "UbuntuServer" -Skus "14.04.3-LTS" -Version "latest"

$vm2=Add-AzureRmVMNetworkInterface -VM $vm2 -Id $nic2.Id

$disk2Name="ub-os-disk"
$storageAcc=Get-AzureRmStorageAccount -ResourceGroupName $resourceGroup -Name $storageAccountName
$osDisk2Uri=$storageAcc.PrimaryEndpoints.Blob.ToString() + "vhds/" + $disk2Name  + ".vhd"
$vm2=Set-AzureRmVMOSDisk -VM $vm2 -Name $disk2Name -VhdUri $osDisk2Uri -CreateOption fromImage

New-AzureRmVaM -ResourceGroupName $resourceGroup -Location $location -VM $vm2