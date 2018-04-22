$resourceGroup = "psod-iaas-m3"
$location = "North Europe"
New-AzureRmResourceGroup -Name $resourceGroup -Location $location

New-AzureRmResourceGroupDeployment -Name 'm3-demo7' `
                                   -ResourceGroupName $resourceGroup `
                                   -TemplateFile  '' `
                                   -TemplateParameterFile ''