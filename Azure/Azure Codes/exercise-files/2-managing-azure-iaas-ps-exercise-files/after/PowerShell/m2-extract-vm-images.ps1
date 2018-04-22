$resourceGroup = "psod-iaas"
$vmName = "win-web"
$vm2Name = "ub-proxy"

#Windows Server - after sysprep
Stop-AzureRmVM -ResourceGroupName $resourceGroup -Name $vmName
Set-AzureRmVM -ResourceGroupName $resourceGroup -Name $vmName -Generalized
Save-AzureRmVMImage -ResourceGroupName $resourceGroup -Name $vmName -DestinationContainerName "vm-images" -VHDNamePrefix "win-web-app" -Path "win-web-app.json"

#Linux Server - after waagent
Stop-AzureRmVM -ResourceGroupName $resourceGroup -Name $vm2Name
Set-AzureRmVM -ResourceGroupName $resourceGroup -Name $vm2Name -Generalized
Save-AzureRmVMImage -ResourceGroupName $resourceGroup -Name $vm2Name -DestinationContainerName "vm-images" -VHDNamePrefix "ub-proxy" -Path "ub-proxy.json"

Remove-AzureRmVM -ResourceGroupName $resourceGroup -Name $vmName
Remove-AzureRmVM -ResourceGroupName $resourceGroup -Name $vm2Name