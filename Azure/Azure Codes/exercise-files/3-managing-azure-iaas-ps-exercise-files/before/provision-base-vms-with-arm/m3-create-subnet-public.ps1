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
    $VnetName,    
    [Parameter(Mandatory=$true)]
    [Int] 
    $SubnetIndex,   
    [Parameter(Mandatory=$true)]
    [String] 
    $LoadBalancerName,    
    [Parameter(Mandatory=$true)]
    [String] 
    $AddressPrefix
)

$vnet = Get-AzureRmVirtualNetwork -Name $VnetName -ResourceGroupName $ResourceGroupName
Add-AzureRmVirtualNetworkSubnetConfig -VirtualNetwork $vnet -Name "$LoadBalancerName-backend" `
                                      -AddressPrefix $AddressPrefix 
$vnet = Set-AzureRmVirtualNetwork -VirtualNetwork $vnet 


$pip = New-AzureRmPublicIpAddress -Name "$VnetName-pip" -ResourceGroupName $ResourceGroupName `
                                  -Location $Location -AllocationMethod Static `
                                  -DomainNameLabel "$VnetName-public"

$frontEndIp = New-AzureRmLoadBalancerFrontendIpConfig -Name "$LoadBalancerName-frontend" `
                                                      -PublicIpAddress $pip

$backEndPool = New-AzureRmLoadBalancerBackendAddressPoolConfig -Name "$LoadBalancerName-backend"

$healthProbe = New-AzureRmLoadBalancerProbeConfig -Name "$LoadBalancerName-probe" `
                                                  -Protocol Http -Port 80 -RequestPath "/" `
                                                  -IntervalInSeconds 10 -ProbeCount 3

$lbRule = New-AzureRmLoadBalancerRuleConfig -Name "HTTP" -FrontendIpConfiguration $frontEndIp `
                                            -BackendAddressPool $backEndPool -Probe $healthProbe `
                                            -Protocol Tcp -FrontendPort 80 -BackendPort 80


New-AzureRmLoadBalancer -ResourceGroupName $ResourceGroupName -Location $Location -Name "$LoadBalancerName" `
                        -FrontendIpConfiguration $frontEndIp -BackendAddressPool $backEndPool `
                        -LoadBalancingRule $lbRule -Probe $healthProbe                                  