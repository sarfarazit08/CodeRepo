# Azure Virtual Networks

## Module 1 – Planning Virtual Networks

As with on-premises networks, Microsoft Azure networks need to be planned carefully to ensure that they work as expected. However, you should find that your knowledge of planning on-premises networks translates relatively simply into the Microsoft Azure environment. In this module, you will:

+ Learn how virtual networks can be used to support virtual machines and PaaS cloud services.
+ Learn about the features supported by Azure virtual networks.
+ Learn how on-premises computers can connect to VMs in an Azure virtual network.
+ Plan a VPN connection from one Azure virtual network to another.
+ Learn how to design IP address space and subnet allocation.

## Module 2 – Managing and Deploying Virtual Networks

In the second module, you move on from the planning process to review how to create and manage the virtual networks that you create. You will configure virtual networks using both the Microsoft Azure Portal and PowerShell. In this module, you will:

+ Create and configure virtual networks (VNETs) by using the Microsoft Azure Management Portal.
+ Create a virtual machine and deploy that VM into a VNET by using the Microsoft Azure Portal.
+ Create a VNET by using PowerShell with the Azure Resource Manager deployment model
+ Deploy a virtual machine into a VNET by using PowerShell.
+ Learn to navigate the schema of a network configuration file.
+ Export and import network configuration files to configure the virtual networks in an Azure subscription.

## Module 3 – IP Addressing

You can assign IP addresses to Azure resources to communicate with other Azure resources, your on-premises network, and the Internet. In this module, you will:

+ Learn about public and private IP addressing.
+ Assign static IP addresses.
+ Assign public IP addresses.
+ Use multiple NICs in Azure virtual machines.
+ Define rules and plan for network security groups.

## Module 4 – Network Services

Virtual Networks in Azure have a range of features that help you to group virtual machines and cloud services and connect to VNets from on-premises or internet-connected machines. In this module, you will:

+ Learn how to configure Azure DNS.
+ Learn how use to Load Balancer.
+ Learn how to configure Azure Traffic Manager.
+ Learn how to configure Application Gateway.

## Module 5 – Intersite Connectivity

In this fifth module, you will learn how to establish connectivity between two or more sites in Microsoft Azure, as well as how to connect from your on-premises computers to Azure virtual networks. In this module, you will:

+ Learn about the options for inter-site connectivity.
+ Configure a Point-to-Site VPN.
+ Configure site-to-site VPNs.
+ Configure VNet-to-VNet VPNs.
+ Learn how to use ExpressRoute.
+ Understand important considerations when configuring inter-site connectivity.

### Azure Networking Components Overview

![Azure Networking Components](http://www.calvyn.com/wp-content/uploads/2017/01/Azure_Components.png)

Illustration showing all of the components of Azure. Highlights the Networking components, which are listed as Virtual Networks, Azure DNS, Application Gateway, Traffic Manager, ExpressRoute, and Load Balancer.

A major incentive for adopting cloud solutions such as Azure is to enable information technology (IT) departments to move server resources to the cloud. This can save organizations money, and simplify operations by removing the need to maintain expensive datacenters with uninterruptible power supplies, generators, multiple fail-safes, clustered database servers, and so on. This is particularly advantageous for small and medium-sized companies, which might not have the expertise to maintain their own robust infrastructure.

Once the resources are moved to Azure, they require the same networking functionality as an on-premises deployment, and in specific scenarios require some level of network isolation. Azure networking components offer a range of functionalities and services that can help organizations design and build cloud infrastructure services that meet their requirements.

Key terminology for Azure Networking is listed below :

#### Virtual networks

Azure Virtual Network is a fundamental component that acts as an organization’s network in Azure. Organizations can use virtual networks to connect resources. Virtual networks in Microsoft Azure are network overlays that you can use to configure and control connectivity between Azure resources such as VMs and load balancers.

#### IP addresses

VMs, Azure load balancers, and application gateways in a single virtual network require unique IP addresses in the same way as clients in an on-premises subnet do. This enables these resources to communicate with each other. There are two types of IP addresses that are used in a virtual network:

_Private IP addresses_. A private IP address is allocated to a VM dynamically or statically from the defined scope of IP addresses in the virtual network. This address is used by VMs in the virtual network to communicate with other VMs in the same virtual network connected VNets/networks through a gateway/ExpressRoute connection.

_Public IP addresses_. Public IP addresses allow Azure resources to communicate with external clients, and are assigned directly at the virtual network interface card of the VM or to the load balancer.

#### Subnets

You can further divide your network by using subnets for logical and security isolation of Azure resources. Each subnet contains a range of IP addresses that fall within the virtual network address space.

#### Network interface card

VMs communicate with other VMs and other resources on the network by using virtual network interface cards (NICs). Virtual NICs configure VMs with private and optional public IP address. VMs can have more than one NIC for different network configurations.

#### DNS

The Domain Name System (DNS) enables clients to resolve user-friendly fully qualified domain names (FQDNs), such as [www.adatum.com,](http://www.adatum.com,) to IP addresses. Azure provides a DNS system to support many name resolution scenarios. However, in some cases, such as hybrid connection you might need to configure an external DNS system to provide name resolution for virtual machines on a virtual network.

#### Azure load balancer and internal load balancer

To increase availability and scalability, you can create two or more VMs that publish the same application. For example, if three VMs host the same website, you might want to distribute incoming traffic between them and ensure that if one VM fails, traffic is distributed automatically to the other two. You can use an Azure load balancer to enable this traffic distribution between VMs. In this configuration, a single endpoint is shared between multiple VMs. The Azure load balancer automatically distributes requests across those VMs as the requests arrive at the endpoint. You can use two types of Azure load balancers:

_Internal load balancer_. The internal load balancer enables you to load balance traffic between VMs in the same cloud service (for classic model), or between VMs and a virtual network with a regional scope, where the input IP address of the load balancer is a private IP address.

_Internet-facing load balancer_. The internet-facing load balancer enables you to load balance incoming Internet traffic to VMs.

#### Application gateway

Application gateways provide load-balanced solutions for network traffic that is based on the HTTP protocol. They use routing rules as application-level policies that can offload Secure Sockets Layer (SSL) processing from load-balanced VMs. In addition, you can use application gateways for a cookie-based session affinity scenario.

#### Traffic Manager

Microsoft Azure Traffic Manager is another load-balancing solution that is included within Azure. You can use Traffic Manager to load balance between endpoints that are located in different Azure regions, at hosted providers, or in on-premises datacenters. These endpoints can include Azure VMs and Azure websites. You can configure this load-balancing service to support priority or to ensure that users connect to an endpoint that is close to their physical location for faster response.

#### Network security groups

You can use network security groups to provide network isolation for Azure resources by defining rules that can allow or deny specific traffic to individual VMs or subnets. This enables you to design your Azure virtual network to provide a network experience that is similar to an on-premises network. You can achieve the same functionality in your Azure virtual network as you would in the on-premises networks, such as perimeter networks (also known as DMZ or demilitarized zone).

#### User Defined Routes

User Defined Routes (UDR) control network traffic by defining routes that specify the next hop of the traffic flow. You can assign User Defined Routes to virtual network subnets.

#### Forced tunneling

With forced tunneling you can redirect internet bound traffic back to the company’s on-premises infrastructure. Forced tunneling is commonly used in scenario where organizations want to implement packet inspection or corporate audit.

#### Regional virtual networks

Azure Virtual Network is bound to Azure subscriptions and it is not possible for multiple subscriptions to use the same Azure virtual network. If you need to provide communications between different Azure subscriptions, you need to create separate Azure virtual networks in each subscription and then use site-to-site virtual network connections or the Microsoft Azure service ExpressRoute, to connect them. All new virtual networks are regional virtual networks. This means that they can span a complete Azure region or datacenter. This differs from the legacy implementation of virtual networks in Azure, which were restricted to a single affinity group, allowing you to co-locate virtual networks, storage accounts, and services in the physical proximity to each other within the same area of a single datacenter. If you have older virtual networks in your subscription, these could be tied to an affinity group. However, over time, you need to migrate all virtual networks to regional virtual networks and remove their ties to specific affinity groups.

#### Cross-premises network connectivity

Virtual networks in Microsoft Azure also enable you to extend your on-premises networks to the cloud. To extend your on-premises network, you can create a virtual private network (VPN) between your on-premises computers or networks and an Azure virtual network. Alternatively, you can use ExpressRoute to provide a connection to an Azure virtual network that does not cross the Internet. Using these two methods, you can enable on-premises users to access Azure services as if they were physically located on-premises in your own datacenter.

To connect to an Azure virtual network from an on-premises network, you can use:

*   A point-to-site VPN
*   A site-to-site VPN
*   ExpressRoute
*   VNet-to-VNet VPN

For more information, you can see:  

+ Azure Virtual Network: [https://aka.ms/edx-azure203x-az01](https://aka.ms/edx-azure203x-az01)  
+ Microsoft Azure: [https://aka.ms/edx-azure203x-az02](https://aka.ms/edx-azure203x-az02)  
+ Azure Load Balancer:[https://aka.ms/edx-azure203x-az03](https://aka.ms/edx-azure203x-az03)  
+ Application gateways:[https://aka.ms/edx-azure203x-az3](https://aka.ms/edx-azure203x-az3)  
+ Domain Name System (DNS) :[https://aka.ms/edx-azure203x-az4](https://aka.ms/edx-azure203x-az4)  
+ Microsoft Azure Traffic Manager:[https://aka.ms/edx-azure203x-az5](https://aka.ms/edx-azure203x-az5)

### Overview of Azure Virtual Network Features

Azure virtual networks define an organization’s network in the cloud, where the administrators can have full control over IP address assignments, name resolution, security settings, and routing rules. The next few units in this module will provide a broad topology of Azure Networking features to lay the groundwork for deeper dives later in the course.

![A diagram that shows, on the left, the local network represented by a desktop computer, and on the right, an Azure Virtual network, represented by a VM. In between is a funnel connecting them with the word VPN above it.](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/4af36669b3ee6b672a3edabd2f54f0c6/asset-v1:Microsoft+AZURE203x+1T2018+type@asset+block/M1L1T3_pL2gvGp.png)

### Azure Resource Manager Deployment Model

When you create a VM with the Azure Resource Manager deployment model, you then need to place it in a virtual network to receive IP address configurations and to connect to other VMs or other resources that you create in Azure. Azure Resource Manager contains a network provider that provides advanced control and network management capabilities. With Azure Resource Manager, you can benefit from:

*   Faster configuration due to resources being grouped.
*   Easier management.
*   Customization and deployment based on JavaScript Object Notation (JSON) templates.
*   Networking resources such as IP addresses, DNS settings, or NICs are managed independently and can be assigned to VMs, Azure load balancers, or application gateways.

You can create Azure network resources by using :

+ the Azure Portal
+ Azure PowerShell module
+ Azure command-line interface (Azure CLI)
+ using deployment templates.

By default, you can create up to 50 virtual networks per subscription per region, although you have the ability to increase this limit to 500 by contacting Azure support. These virtual networks are free of charge, but other dependent resources such as Public IP or application gateways are charged.

> Microsoft is moving towards the Resource Manager deployment model. If you’ve been with Azure for a while, you’re probably aware that Azure started with the Azure Service Management (ASM) model for managing resources You will likely be aware that there are differences between the older "classic" portal, which used the ASM model, and the current Azure portal which uses the ARM deployment model. The ASM model has been phased out in favor of the ARM model, and if you have any ASM resources, it would benefit you to move those to the new ARM deployment model.

For more information, you can see:  
Windows Azure: [https://aka.ms/edx-azure203x-az6](https://aka.ms/edx-azure203x-az6)

### Cross-Premises Network Connectivity

When you move a server to the cloud, you move it further from the users on your premises. This physical move should not place any barrier between the users and the resources they need to do their job. You can use a VPN connection to remove any potential connectivity barriers. A VPN can connect your on-premises network to an Azure virtual network and all the VMs and PaaS cloud services it contains. This connection means that users can connect to Azure resources as if they were local.

To connect to an Azure virtual network from an on-premises network, you can use one of the following methods:

*   **A point-to-site VPN**: This is a VPN that connects individual computers to an Azure virtual network. You must create a VPN connection from each on-premises computer that you want to connect to the Azure virtual network.
*   **A site-to-site VPN**: This is a VPN that connects an on-premises network and all its computers to an Azure virtual network. To create this connection, you must configure a gateway and IP routing in the on-premises network; it is not necessary to configure individual on-premises computers.
*   **ExpressRoute**: An ExpressRoute connection is a dedicated service that does not connect across the Internet. Instead, it uses a private connection to Azure datacenters, provided by a network provider. By using ExpressRoute, you can increase security, reliability, and bandwidth.
*   **VNet-to-VNet connection**: You also can create a VPN that connects two Azure virtual networks.

Whenever you want to connect to an Azure virtual network, you must provision a VPN gateway in Azure. The VPN gateway routes traffic between VMs and PaaS cloud services in the virtual network, and computers at the other end of the connection.

For more information, you can see:  
VPN Gateway: [https://aka.ms/edx-azure203x-az7](https://aka.ms/edx-azure203x-az7)  
ExpressRoute: [https://aka.ms/edx-azure203x-az8](https://aka.ms/edx-azure203x-az8)

### Connecting to Virtual Networks

![An illustration showing a multi-site connection, where two on premises networks in different regions are connected to two virtual networks. the two virtual networks have a vnet to vnet connection.](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/f32a1fa868960ea4c86db960cd319a8f/asset-v1:Microsoft+AZURE203x+1T2018+type@asset+block/M1L1T6_xxyMgAL.png)

Before you can use a VM or PaaS cloud service within an Azure VNet, you must connect to that VNet. There are several ways to make this connection.

#### Cloud-Only Virtual Networks

You can choose not to make any kind of virtual private network (VPN) connection to a VNet. Instead, when you create a VM or cloud service, you can specify endpoints that external clients can connect to. An endpoint is a VIP and a port number. Therefore an endpoint can be used only for a specific protocol, such as connecting a Remote Desktop Protocol (RDP) client or browsing a website. These VNets are known as cloud-only virtual networks. A dynamic routing gateway is not required in the VNet. Endpoints are published to the Internet, so they can be used by anyone with an Internet connection, including your on-premises computers.

#### Point-to-Site VPNs

A simple way to connect a VPN to an Azure VNet is to use a Point-to-Site VPN. In these VPNs, you configure the connection on individual on-premises computers. No extra hardware is required but you must complete the configuration procedure on every computer that you want to connect to the VNet. Point-to-site VPNs can be used by the client computer to connect to a VNet from any location with an Internet connection. Once the VPN is connected, the client computer can access all VMs and cloud services in the VNet as if they were running on the local network.

#### Site-to-Site VPNs

To connect all the computers in a physical site to an Azure VNet, you can create a Site-to-Site VPN. In this configuration, you do not need to configure individual computers to connect to the VNet, instead you configure a VPN device, which acts as a gateway to the VNet. You must also configure routing tables to forward traffic to the VNet. Once these steps are completed, all computers in the local on-premises network can connect to VMs and services in the VNet as if they were local resources. You can use a Windows Server 2012 computer running RRAS as a gateway to the VNet. Alternatively, there are a range of third-party VPN devices that are known to be compatible. If you have a VPN device that is not on the known compatible list, you may be able to use it if it satisfies the list of gateway requirements.

#### ExpressRoute

ExpressRoute is a service that enables Azure customers to create a dedicated connection to Azure, which does not connect through the public Internet. This contrasts with VPNs, which use encryption to tunnel securely through the public Internet. Because ExpressRoute connections are dedicated, they can offer faster speeds, higher security, lower latencies, and higher reliability than VPNs.

#### VNet-to-VNet

Connecting a virtual network to another virtual network (VNet-to-VNet) is similar to connecting a virtual network to an on-premises site location. Both connectivity types use a VPN gateway to provide a secure tunnel using IPsec/IKE. The VNets you connect can be in different subscriptions and different regions. You can combine VNet to VNet communication with multi-site configurations. This lets you establish network topologies that combine cross-premises connectivity with inter-virtual network connectivity.

### IP Addressing in Virtual Networks

#### IP Addresses

VMs, Azure load balancers, and application gateways in a single virtual network require unique IP addresses in the same way as clients in an on-premises subnet do. This enables these resources to communicate with each other. There are two types of IP addresses that are used in a virtual network:

*   Private IP addresses. A private IP address is allocated to a VM dynamically or statically from the defined scope of IP addresses in the virtual network. This address is used by VMs in the virtual network to communicate with other VMs in the same virtual network connected VNets/networks through a gateway/ExpressRoute connection.
    
*   Public IP addresses. Public IP addresses allow Azure resources to communicate with external clients, and are assigned directly at the virtual network interface card of the VM or to the load balancer.
    

#### IP Addressing in Virtual Networks

When you create a virtual network, you define the scope of IP addresses that you can use for allocations to the networking resources. The scope of IP addresses can use both private IPv4 ranges and public IP ranges. You can use the following private IP address scopes:

*   10.x.x.x
*   172.16.x.x – 172.31.x.x
*   192.168.x.x

The allocation method of these IP addresses is dynamic by using Azure-provided Dynamic Host Configuration Protocol (DHCP). An IP address that is allocated by DHCP has infinite duration and is released only if you deallocate (stop) the VM. You can configure static private IP addresses from the range of IP addresses defined within the virtual network, which will be reserved for specific VMs.

For VMs that need direct access from the Internet, you can configure public IP addresses. Public IP addresses are allocated dynamically when you create a VM, and are bound to the NICs. You also can configure static public IP addresses and associate them to a load balancer, application gateway or a network interface card of the VM. For example, you can use the following command to configure a public IP address by using the static allocation method:

    	$publicIP = New-AzureRmPublicIpAddress -Name PublicIp -ResourceGroupName AdatumRG 
    	-Location centralus –AllocationMethod Static -DomainNameLabel loadbalancernrp

### Subnets

You can further divide your network by using subnets for logical and security isolation of Azure resources. Each subnet contains a range of IP addresses that fall within the virtual network address space. You can divide a VNet into multiple subnets for organization and security. VMs and PaaS role instances deployed to subnets (same or different) within a VNet can communicate with each other without any extra configuration. You can also configure route tables and NSGs to a subnet.

#### Subnet Allocation

You must also sub-divide the VMs and cloud services in your VNet by providing one or more subnets. The range you specify for a subnet must be completely contained within its parent VNet’s address space. Within each subnet, the first three IP addresses and the last IP address are reserved and cannot be used for VMs or cloud services. The smallest subnets that are supported use a 29-bit subnet mask.

#### Using Static Internal IP Addresses

Because clients use DNS to resolve a name to an IP address, many VMs and services can receive new DIPs without interrupting their service to users. In addition, because DHCP leases are infinite in Azure VNets, IP addresses rarely change. However, sometimes an IP change does happen. For example, if a new VM is created while another VM is in the Stopped (Deallocated) state, the new VM may take the old VMs original address.

If you expect an IP address change to cause problems for a server, you can use a static internal IP address for that VM. For example, a DNS server should have a static IP address because clients may not be able to locate it if its address changes.

### Planning IP Address Space

You can control the dynamic IPs (DIPs) assigned to VMs and cloud services within an Azure VNet by specifying an IP addressing scheme. Planning an IP addressing scheme within Azure VNets is much like planning an IP addressing scheme on-premises. The same ranges are often used and the same rules applied. However there are conditions that are unique to Azure VNets.

#### Private Address Spaces

The RFC 1918 standard defines three private address spaces that are never used for addressing on the Internet. Administrators use these ranges behind Network Address Translation (NAT) devices to ensure unique addresses used within intranets never prevent communication with Internet servers. These three address spaces are the only ones that are supported within an Azure VNet. The address spaces are:      

*   10.0.0.0/8. This address space includes all addresses from 10.0.0.1 to 10.255.255.255.     
*   172.16.0.0/12. This address space includes all addresses from 172.16.0.1 to 172.31.255.255.      
*   192.168.0.0/16. This address space includes all addresses from 192.168.0.1 to 192.168.255.255.

When you specify an address space for a VNet, you usually specify a much smaller range within one of the private address spaces. For example, if you specified the address space 10.1.1.0/24, that means that all addresses from 10.1.1.1 to 10.1.1.255 should be routed into your VNet.

In a cloud-only virtual network, you can specify any address range from the RFC 1918 private spaces. However, if you connect to a VNet with a VPN or ExpressRoute, you must ensure that the address space is unique and does not overlap any of the ranges that are already in use on-premises or in other VNets.

> **Correction!** You can use public IP address ranges, and any IP address range defined in RFC 1918. See the following [update](https://azure.microsoft.com/en-us/updates/non-rfc-1918-space-is-now-allowed-in-a-virtual-network/).

> Always plan to use an address space that is not already in use in your organization, either on-premises or in other VNets. Even if you plan for a VNet to be cloud-only, you may want to make a VPN connection to it later. If there is any overlap in address spaces at that point, you will have to reconfigure or recreate the VNet.

### DNS

Names of resources that are created in Azure can be resolved by using Azure-provided name resolution or by using a customer provided DNS server. For example, a VM can use the Azure-provided DNS to resolve the name of any other VM in the same virtual network. However, in a hybrid scenario where your on-premises network is connected to an Azure virtual network through a VPN or ExpressRoute circuit, an on-premises computer cannot resolve the name of a VM in an Azure virtual network until you configure the DNS servers with a record for the VM. Furthermore, resources created in the same virtual network and deployed with Azure Resource Manager (ARM) share the same DNS suffix; therefore, in most cases name resolution by using FQDN is not required. For virtual networks that are deployed by using the Azure classic deployment model, the DNS suffix is shared among VMs that belong to the same cloud service. Therefore, name resolution between VMs that belong to different cloud services in the same virtual network require the use of FQDN.

### Planning for Name Resolution in Azure Virtual Networks

![A table showing name resolution scenarios, location, and name resolution provision.](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/30a0c4dee1de92591c94bd631328fdf5/asset-v1:Microsoft+AZURE203x+1T2018+type@asset+block/M1L2T5_c9djaJD.png)

+ Between VMs, Same cloud service, Use Azure provided name resolution. 
+ Between role instances or VMS, Same VNet but different cloud services, Use your own DNS Implementation. 
+ Between VMs or role instances and on premises computers, Azure VNets and on-premises, Use your own DNS server/DNS implementation. 
+ Between on-premises computers and public endpoints, on-premises to azure, Use Microsoft Azure external name resolution.

Name resolution is the process by which a computer name is resolved to an IP address. A computer can use the IP address to connect to the named computer by using the IP address, which the user may find difficult to remember.

Azure provides a name resolution service that enables VMs and cloud services within Azure to communicate by name. However, some configurations exceed the reach of the Azure name resolution service. You must plan name resolution carefully to ensure that all computers and VMs can connect.

### Name Resolution Scenarios

Consider the following situations:

*   VMs in the same cloud service. VMs can resolve the names of all other VMs in the same cloud service automatically by using the internal Azure name resolution.
*   VMs in the same VNet. If the VMs are in different cloud services but within a single VNet, those VMs can resolve IP addresses for each other by using the internal Azure name resolution service and their Fully Qualified Domain Names (FQDNs). This is supported only for the first 100 cloud services in the VNet. Alternatively, use your own DNS system to support this scenario.
*   Between VMs in a VNet and on-premises computers. To support this scenario you must use your own DNS system.
*   Between VMs in different VNets. To support this scenario you must use your own DNS system.
*   Between on-premises computers and public endpoints. If you publish an endpoint from a VM in an Azure VNet, the Azure-provided external name resolution service will resolve the public VIP. This also applies for any internet-connected computers that are not on your premises.

> If two VMs are deployed in different IaaS cloud services but not in a VNet, they cannot communicate at all, even by using DIPs. Therefore name resolution is not applicable.

If you are planning to use your own DNS system, you must ensure that all computers can reach a DNS server for registering and resolving IP addresses. You can either deploy DNS on a VM in the Azure VNet or have VM register their addresses with an on-premises DNS server. Your DNS server must meet the following requirements:

*   The server must support Dynamic DNS (DDNS) registration.
*   The server must have record scavenging switched off. Because DHCP leases in an Azure VNet are infinite, record scavenging can remove records that have not been renewed but are still correct.
*   The server must have DNS recursion enabled.
*   The server must be accessible on TCP/UDP port 53 from all clients.

### Course Resources

There is a lot of information on Microsoft Azure. Here are just a few resources that are available.

*   [Microsoft Virtual Academy](https://mva.microsoft.com/)  offers online Microsoft training offers beginners or seasoned professionals experience and practice with Windows Server. This site is home to the very popular Jump Start series.
*   Start with the [Azure](https://aka.ms/edx-azure203x-az1) home page for links to blogs, product information, sales, pricing, resources, and support. 
*   Visit the [Azure Documentation](https://azure.microsoft.com/en-us/documentation/) center for the latest information about Azure.
*   The [Microsoft Azure Blog](https://azure.microsoft.com/en-us/blog/) is a great place to read about new product announcements.  
*   Check out the Microsoft Windows Server [TechNet Library](https://technet.microsoft.com/en-us/library/bb625087.aspx) for Technical Information, Downloads, and Resources.
*   Subscribe to [Channel 9](https://channel9.msdn.com/Search?term=azure#ch9Search) for videos, forums, and events.
*   The [Microsoft Press Store](https://www.microsoftpressstore.com/search/index.aspx?query=windows+server+2012&x=0&y=0) offers a large variety of Azure ebooks and books.


