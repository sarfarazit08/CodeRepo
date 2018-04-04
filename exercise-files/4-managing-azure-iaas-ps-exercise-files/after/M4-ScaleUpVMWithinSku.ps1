$resourceGroup = "psod-iaas-m3v2"
$location = "North Europe"
$vmName = "win-web-0"
$nicName = "win-web-0-nic"

$vm = Get-AzureRmVM -ResourceGroupName $resourceGroup -Name $vmName

$vm.HardwareProfile.VmSize = 'Standard_A2'

Update-AzureRmVM -ResourceGroupName $resourceGroup -VM $vm
