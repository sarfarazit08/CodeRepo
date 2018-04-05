$resourceGroup = "psod-iaas-m3v2"
$location = "North Europe"
$vmName = "win-web-0"

$vm = Get-AzureRmVM -ResourceGroupName $resourceGroup -Name $vmName

Stop-AzureRmVM -ResourceGroupName $resourceGroup -Name $vmName

$vm.StorageProfile.OsDisk.DiskSizeGB = 600

Update-AzureRmVM -ResourceGroupName $resourceGroup -VM $vm

Start-AzureRmVM -ResourceGroupName $resourceGroup -Name $vmName