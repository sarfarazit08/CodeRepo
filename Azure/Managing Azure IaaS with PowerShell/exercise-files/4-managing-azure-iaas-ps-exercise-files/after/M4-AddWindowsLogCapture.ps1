$resourceGroup = "psod-iaas-m3"
$location = "North Europe"
$vmName = "win-web-dsc-0"

$vm = Get-AzureRmVM -ResourceGroupName $resourceGroup -Name $vmName

$configFile = '.\M4-WindowsDiagnosticConfig.xml'

Set-AzureRmVMDiagnosticsExtension -ResourceGroupName $resourceGroup -VMName $vmName `
                                  -DiagnosticsConfigurationPath $configFile `
                                  -StorageAccountName 'psodiaasm3'
