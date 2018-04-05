$resourceGroup = "psod-iaas-m3v2"
$location = "North Europe"
$vmName = "win-web-0"
$nicName = "win-web-0-nic"

. .\New-SWRandomPassword.ps1
$username = "elton"
$password = New-SWRandomPassword

Set-AzureRmVMAccessExtension -ResourceGroupName $resourceGroup -Location $location -VMName $vmName `
                             -Name "access-ext"  -UserName $username -Password $password


