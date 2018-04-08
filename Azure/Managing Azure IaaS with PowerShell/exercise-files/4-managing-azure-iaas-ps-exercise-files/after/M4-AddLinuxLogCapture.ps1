$resourceGroup = "psod-iaas-m3"
$location = "North Europe"
$vmName = "ub-proxy-dsc-0"

$publicConfig = '{
  "perfCfg":[
    {
     "query":"SELECT UsedMemory,AvailableMemory FROM SCX_MemoryStatisticalInformation",
     "table":"Memory"
    }
  ],
  "EnableSyslog":"true"
}'

$privateConfig = '{
    "storageAccountName": "psodiaasm3",
    "storageAccountKey": "qCZJSdMwpq1uSZV392b/E4AE1MQ9nt0pri75cHZKBWJtftxWN05HyATlfXNBbXvRUNHZnbP0YcK5s9t7oJuIJg=="
}'

$extensionName = 'LinuxDiagnostic'
$publisher = 'Microsoft.OSTCExtensions'
$version = '2.3'

Set-AzureRmVMExtension -ResourceGroupName $resourceGroup -VMName $vmName -Location $location `
                       -Name $extensionName -Publisher $publisher `
                       -ExtensionType $extensionName -TypeHandlerVersion $version `
                       -Settingstring $publicConfig -ProtectedSettingString $privateConfig