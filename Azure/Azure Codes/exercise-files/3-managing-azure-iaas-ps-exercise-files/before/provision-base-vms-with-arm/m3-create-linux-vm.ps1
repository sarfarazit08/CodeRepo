Param
(
    [Parameter(Mandatory=$true)]
    [String] 
    $ResourceGroupName,    
    [Parameter(Mandatory=$true)]
    [String] 
    $Location,
    [Parameter(Mandatory=$true)]
    [String]
    $StorageAccountName,    
    [Parameter(Mandatory=$true)]
    [String] 
    $VmName,    
    [Parameter(Mandatory=$true)]
    [String] 
    $VnetName,    
    [Parameter(Mandatory=$true)]
    [Int] 
    $SubnetIndex,  
    [Parameter(Mandatory=$true)]
    [String]
    $AvailabilitySetId,
    [Parameter(Mandatory=$true)]
    [String] 
    $LoadBalancerName
)

$storageAccount = Get-AzureRmStorageAccount -ResourceGroupName $ResourceGroupName -Name $StorageAccountName
$vnet = Get-AzureRmVirtualNetwork -Name $VnetName -ResourceGroupName $ResourceGroupName

$nicName = "$vmName-nic"

$lb = Get-AzureRmLoadBalancer -ResourceGroupName $ResourceGroupName -Name $LoadBalancerName

$nic = New-AzureRmNetworkInterface -Name $nicName -ResourceGroupName $ResourceGroupName `
                                   -Location $Location -Subnet $vnet.Subnets[$SubnetIndex] `
                                   -LoadBalancerBackendAddressPool $lb.BackendAddressPools[0]

$vm = New-AzureRmVMConfig -VMName $VmName -VMSize "Standard_A1" -AvailabilitySetId $AvailabilitySetId

$username = "elton"
$password = ConvertTo-SecureString "Plur*ls!ght" -AsPlainText -Force
$cred = new-object -typename System.Management.Automation.PSCredential -argumentlist $username, $password

$vm = Set-AzureRmVMOperatingSystem -VM $vm -Linux  -ComputerName $VmName -Credential $cred 
$vm = Set-AzureRmVMSourceImage -VM $vm -PublisherName "Canonical" `
                               -Offer "UbuntuServer" -Skus "14.04.3-LTS" -Version "latest"

$vm = Add-AzureRmVMNetworkInterface -VM $vm -Id $nic.Id

$diskName = $VmName + "-os-disk"
$osDiskUri = $storageAccount.PrimaryEndpoints.Blob.ToString() + "vhds/" + $diskName  + ".vhd"
$vm=Set-AzureRmVMOSDisk -VM $vm -Name $diskName -VhdUri $osDiskUri -CreateOption fromImage

New-AzureRmVM -ResourceGroupName $ResourceGroupName -Location $Location -VM $vm 