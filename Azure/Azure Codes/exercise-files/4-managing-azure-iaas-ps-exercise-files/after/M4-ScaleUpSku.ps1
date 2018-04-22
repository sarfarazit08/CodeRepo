$resourceGroup = "psod-iaas-m3v2"
$location = "North Europe"

For ($i=0; $i -lt 3; $i++) {
    
    $vmName = "win-web-$i"
    Stop-AzureRmVM -ResourceGroupName $resourceGroup -Name $vmName
}

For ($i=0; $i -lt 3; $i++) {
    
    $vmName = "win-web-$i"
    $vm = Get-AzureRmVM -ResourceGroupName $resourceGroup -Name $vmName
    $vmSize = $i+1
    $vm.HardwareProfile.VmSize = "Standard_D$vmSize"
    Update-AzureRmVM -ResourceGroupName $resourceGroup -VM $vm
    Start-AzureRmVM -ResourceGroupName $resourceGroup -Name $vmName
}