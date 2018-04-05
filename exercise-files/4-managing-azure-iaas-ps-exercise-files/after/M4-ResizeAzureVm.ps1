#M4-ResizeAzureVm.ps1

$ResourceGroupName = "CMLAB"
$VMName = "2007CMCEN"
$NewVMSize = "Standard_A5"

$vm = Get-AzureRmVM -ResourceGroupName $ResourceGroupName -Name $VMName
$vm.HardwareProfile.vmSize = $NewVMSize
Update-AzureRmVM -ResourceGroupName $ResourceGroupName -VM $vm