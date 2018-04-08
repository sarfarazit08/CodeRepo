$resourceGroup = "psod-iaas-m3"
$location = "North Europe"

New-AzureRmResourceGroup -Name $resourceGroup -Location $location

$storageAccountName = "psodiaasm3"
$account = New-AzureRmStorageAccount -Name $storageAccountName -ResourceGroupName $resourceGroup `
                                     -Type Standard_LRS -Location $location


#creds
$username = "elton"
$password = ConvertTo-SecureString "Plur*ls!ght" -AsPlainText -Force
$cred = New-Object -TypeName System.Management.Automation.PSCredential `
                   -ArgumentList $username, $password

$i = 0
$vnetName = "iaas-net-$i" 

$subnet=New-AzureRmVirtualNetworkSubnetConfig -Name frontendSubnet -AddressPrefix 10.0.1.0/24
$vnet = New-AzureRmVirtualNetwork -Name $vnetName -ResourceGroupName $resourceGroup -Location $location `
                                  -AddressPrefix 10.0.0.0/16 -Subnet $subnet

$nicName = "ub-proxy-nic-$i"
$pip = New-AzureRmPublicIpAddress -Name $nicName -ResourceGroupName $resourceGroup `
                                  -Location $location -AllocationMethod Dynamic
$nic = New-AzureRmNetworkInterface -Name $nicName -ResourceGroupName $resourceGroup `
                                   -Location $location -SubnetId $vnet.Subnets[0].Id -PublicIpAddressId $pip.Id

$vmName = "ub-proxy-dsc-$i"
$vm = New-AzureRmVMConfig -VMName $vmName -VMSize "Basic_A1"

$vm = Set-AzureRmVMOperatingSystem -VM $vm -Linux  -ComputerName $vmName -Credential $cred 
$vm = Set-AzureRmVMSourceImage -VM $vm -PublisherName "Canonical" `
                               -Offer "UbuntuServer" -Skus "14.04.3-LTS" -Version "latest"

$vm=Add-AzureRmVMNetworkInterface -VM $vm -Id $nic.Id

$diskName = "os-disk-ub-dsc-$i"
$storageAcc = Get-AzureRmStorageAccount -ResourceGroupName $resourceGroup -Name $storageAccountName
$osDiskUri = $storageAcc.PrimaryEndpoints.Blob.ToString() + "vhds/" + $diskName  + ".vhd"
$vm = Set-AzureRmVMOSDisk -VM $vm -Name $diskName -VhdUri $osDiskUri -CreateOption fromImage

New-AzureRmVM -ResourceGroupName $resourceGroup -Location $location -VM $vm

$extensionName = 'DSCForLinux'
$publisher = 'Microsoft.OSTCExtensions'
$version = '2.0'

$publicConfig = '{
  "Mode": "Push",
  "FileUri": "https://psodiaas.blob.core.windows.net/linux-dsc-mof/localhost.mof"
}'

$privateConfig = '{
  "StorageAccountName": "psodiaas",
  "StorageAccountKey": "## TODO - storage account key ##"
}'

Set-AzureRmVMExtension -ResourceGroupName $resourceGroup -VMName $vmName -Location $location `
                       -Name $extensionName -Publisher $publisher -ExtensionType $extensionName `
                       -TypeHandlerVersion $version -SettingString $publicConfig -ProtectedSettingString $privateConfig