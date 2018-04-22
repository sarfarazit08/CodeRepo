$resourceGroup = "psod-iaas-m3"
$location = "North Europe"
$storageAccountName = "psodiaasm3"

#creds
$username = "elton"
$password = ConvertTo-SecureString "Plur*ls!ght" -AsPlainText -Force
$cred = new-object -typename System.Management.Automation.PSCredential -argumentlist $username, $password

$i = 0

$vnetName = "iaas-net-$i" 
$vnet = Get-AzureRmVirtualNetwork -Name $vnetName -ResourceGroupName $resourceGroup

$nicName = "win-web-nic-$i"
$pip = New-AzureRmPublicIpAddress -Name $nicName -ResourceGroupName $resourceGroup `
                                  -Location $location -AllocationMethod Dynamic
$nic = New-AzureRmNetworkInterface -Name $nicName -ResourceGroupName $resourceGroup `
                                   -Location $location -SubnetId $vnet.Subnets[0].Id -PublicIpAddressId $pip.Id

$vmName = "win-web-dsc-$i"
$vm = New-AzureRmVMConfig -VMName $vmName -VMSize "Basic_A1"

$vm = Set-AzureRmVMOperatingSystem -VM $vm -Windows -ComputerName $vmName -Credential $cred `
                                 -ProvisionVMAgent -EnableAutoUpdate
$vm = Set-AzureRmVMSourceImage -VM $vm -PublisherName "MicrosoftWindowsServer" `
                             -Offer "WindowsServer" -Skus "2012-R2-Datacenter" -Version "latest"

$vm = Add-AzureRmVMNetworkInterface -VM $vm -Id $nic.Id

$diskName = "os-disk-win-dsc-$i"
$storageAcc = Get-AzureRmStorageAccount -ResourceGroupName $resourceGroup -Name $storageAccountName
$osDiskUri = $storageAcc.PrimaryEndpoints.Blob.ToString() + "vhds/" + $diskName  + ".vhd"
$vm = Set-AzureRmVMOSDisk -VM $vm -Name $diskName -VhdUri $osDiskUri -CreateOption fromImage

New-AzureRmVM -ResourceGroupName $resourceGroup -Location $location -VM $vm

Publish-AzureRmVMDscConfiguration -ConfigurationPath .\win-web-server-dsc.ps1 `
                                  -ResourceGroupName $resourceGroup -StorageAccountName $storageAccountName 

Set-AzureRmVMDSCExtension -ResourceGroupName $resourceGroup -VMName $vmName -Version '2.15' `
                          -ArchiveBlobName "win-web-server-dsc.ps1.zip" `
                          -ArchiveStorageAccountName $storageAccountName `
                          -ConfigurationName "WebApp"
