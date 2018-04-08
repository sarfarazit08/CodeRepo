$resourceGroup = "psod-iaas-m3v2"
$location = "North Europe"
$vmName = "win-web-0"

$vm = Get-AzureRmVM -ResourceGroupName $resourceGroup -Name $vmName

Add-AzureRmVMDataDisk -VM $vm -Name 'new-data-disk' -VhdUri 'https://psodiaasm3v2.blob.core.windows.net/vhds/win-web-0-data.vhd' `
                      -LUN 0 -Caching ReadOnly -DiskSizeInGB 1023 -CreateOption empty

Update-AzureRmVM -ResourceGroupName $resourceGroup -VM $vm
