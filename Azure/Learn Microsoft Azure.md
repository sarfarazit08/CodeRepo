# Learn Microsoft Azure 

## Introduction 

### What the course covers?

+ Getting setup with an Azure Account
+ What is 'cloud' - hint, its not just a buzzword
+ The different types of cloud - public, private, hybrid and community.
+ Cloud Service Models - Infrastructure as a service (IaaS), Platform as a service (PaaS) and Software as a service (SaaS)
+ The history of Azure ... how it started, version 1 and version 2
+ The Azure global infrastructure platform
+ Architectural foundations - regions, region pairs & Geos
+ Account fundamentals - Subscriptions, directories, resource groups and security
+ Azure Virtual Networking - Key concepts
+ Overview of all Azure Product areas - understand when and where they would be used
+ Azure & AWS Product comparison - understand what products compete and compliment

### Accessing Course Files 

+ [Course Files](https://github.com/LevelUpCloud/LevelUpCloud-Introduction-to-Azure)

## Cloud Fundamentals 

### What's this cloud thing ? 
  + It's not just a buzzword.
  + There is no cloud. It's just a (someone else) computer 
  + Misconception that if something is virtualized then it's cloud. It's not!
  + [Definition of Cloud Computing](http://nvlpubs.nist.gov/nistpubs/Legacy/SP/nistspecialpublication800-145.pdf)
  
#### Essential Charachteristics

+ ___On-demand self-service___: "A consumer can unilaterally provision computing capabilities... ..as needed automatically **without requiring human interaction** with each service provider." 

+ ___Broad network access___: "Capabilities are available over the **network** and accessed through standard mechanisms... " - WebUI, CLI, API, SDK, VPN, Dedicated Lines etc.

+ ___Resource pooling___: "...resources are pooled to serve multiple consumers using a **multi-tenant model**..."

  "There is a sense of **location independence** in that the customer generally has no control or knowledge over the exact location of the provided resources..."

e.g., AWS, Azure, Google Cloud, Office365, Dropbox, Netflix etc.

+ ___Rapid elasticity___: "Capabilities can be elastically provisioned and released... ... to **scale rapidly** outward and inward commensurate with demand."

  "To the consumer, the capabilities available for provisioning often **appear to be unlimited**..."

+ ___Measured service___: "Resource usage can be **Monitored, controlled, and reported,** providing transparency for both the provider and consumer of the utilized service."

### Cloud Deployment Models

| Cloud Flavors | Description |
|-|-|
|Public|Exist on the premis of the vendor for public use. E.g., |
|Private|Exist on the premis of the vendor exclusively for business/private use.|
|Hybrid|Having flavors of both public and private cloud.|
|Community|It's similar to Hybrid cloud in many ways. When a group of organisations club together and make a dedicated cloud plateform specifically for their use - a shared set of requirement(s). E.g., AWS Govt. cloud, Azure Govt. cloud|

+ Public Cloud is **Easy** - lots of examples.
+ Community Cloud is a thing - it exists.
+ Be **skeptical** of claims of Hybrid Cloud.
+ Be **very skeptical** of claims Private Cloud.

### Cloud Service Models : Cloud Service Spectrum

+ Cloud Servies - Products with in the Cloud
  + All cloud product fit somewhere
  + Other Service Models occupy a range somewhere
+ Service Models (\*aas)
  + IaaS : Infrastructure as a service
    + FaaS : Function as a service
    + DaaS : Database as a service
  + PaaS : Plateform as a service
  + SaaS : Software as a service
  + BaaS : Blockchain as a service
+ What the end-user gets
+ What the end-user manages
+ What the end-user sees

![cloudstack](https://acomdpsstorage.blob.core.windows.net/dpsmedia-prod/azure.microsoft.com/en-us/documentation/articles/azure-security-best-practices-software-updates-iaas/20151102073235/sec-cloudstack.png)

As you move from IaaS to PaaS to SaaS you loose flexibility but you gain in terms of ease of management which means less cost and less risk.

## Azure Fundamentals 

### Creating an Azure Account
  + Microsoft Account is what you need first to register for Azure account.
    + Create a new one or use an existing one.
    + You can even use an exiting gmail or other email for creating a MS Account.
  + [Azure Subscription](https://azure.microsoft.com/en-in/)
    + Fill Credit/Debit card details and register for free 30 days trial subscription.
    + You'll get one free trial per person throughout your lifetime of Azure.
  + [Azure Portal](https://portal.azure.com/)

### Azure vs Azure Stack 

+ **Azure** is a public cloud plateform. You can create cloud resources with in Azure Cloud Plateform.
+ **Azure Stack** is a private cloud plateform. It essentially is a set of hardware devices. It comes with
  + Compute
  + Storage
  + Networking
  
  It's the private version of Azure Cloud. It also consists :
    + Azure Backup
    + Azure Site Recovery Manager

### Azure v1 (Classic/ASM : Azure Service Management) vs Azure v2 (ARM : Azure Resource Manager)

+ Azure started in mid 2000's - named **Project Red Dog**

|Azure v1 (Classic : Azure Service Management) | Azure v2 (ARM : Azure Resource Management)|
|-|-|
|Announced in - 2008, Commercially available in - 2010 | Announced in - 2014 as preview, named "Prject Ibiza" |
|Azure v1 - ASM (Azure Service Management)| Azure v2 - ARM (Azure Resource Manager)|
|Classic Azure Portal was named - RDFE (Red Dog Front End)| New Portal/API's/Tooling|

+ Classic Azure Portal :

![Classic Azure Portal](https://gilgrossblog.files.wordpress.com/2017/12/manageportal.png)

+ New Azure Portal: 

![New Azure Portal](https://azurecomcdn.azureedge.net/mediahandler/acomblog/media/Default/blog/41eae6ac-94a3-48b9-9099-4d4df6249e75.jpg)


+ Azure v2 provided these facilities:
  + Building Blocks
  + Individual Resources
  + Resource Groups
  ![Resource Groups](https://media.licdn.com/mpr/mpr/shrinknp_800_800/AAEAAQAAAAAAAAlFAAAAJDk2NDc0NGNiLWY1MjAtNDk5Mi05ZDdkLWMxYjAzMjlmNTFlNA.png)
  + ARM Templates (JSON) : In Azure, you can take the infrastructure you've already have and make a template for it.
  + Tags : Allow you to group resources using one or more tags. It helps you to find/see the resources across the resource groups.
  + Role Based Access Control (RBAC) : Allows you to define a role, assign hat role to a group or a user. That group or user gets the security dicatated by that Role. Role can be applied to :
    + Subscription
    + Resource Group
  + The new portal can access legacy services and legacy configurations.

### Azure Virtual Networks (vNets) and Resource Groups (Azure Building Blocks)

**Virtual Networks**

+ Isolated Network
+ Address Space for the Network
+ Can be 'subnetted' into smaller sub-networks
+ Each of those can have an IP range
+ Can be connected together

**Azure Virtual Networks (vNets)**

+ VNet is a way of building a network on Azure Cloud
+ A way of creating an Isolated portion of Azure for specific purpose
+ Address Space for the Network
+ Can be 'subnetted' into smaller sub-networks
+ Each of those can have an IP range
+ Can be connected together
+ Putting Resources (Azure Virtual Machines) on those subnets.

![Azure Virtual Network](https://acomdpsstorage.blob.core.windows.net/dpsmedia-prod/azure.microsoft.com/en-us/documentation/articles/virtual-networks-overview/20150915062503/figure02.png)

### Demo: Creating Azure VNet and Subnets

![Vnet and Subnets](https://docs.microsoft.com/en-us/azure/includes/media/virtual-networks-create-vnet-scenario-include/vnet-scenario.png)

+ Create a **Resource Group** or use an existing one. Could be created separately or on the go. Name it "VNetDemoRG".
+ Create a **Virtual Network** with name "TestVNet" and address space `192.168.0.0/16`
+ Select "Use existing" and select "VNetDemoRG" resouce group from dropdown.
+ Provide a subnet name "FrontEnd" and address range `192.168.1.0/24` and click "Create".
+ Add another subnet with the name "BackEnd" and address range `192.168.2.0/24`
+ Delete "VNetDemoRG" resource group. It deletes all the associated resources with in the group. Currently it has "TestVNet" as resource.

### Account Structure - Accounts & Subscriptions 



### Global Infrastructure - Geos, Regions, Region Pairs & Availability Zones 
### Role Based Access Control (RBAC) 

## Essential Services 

### Essential Services Introduction 
### COMPUTE 
### DEMO . Azure Marketplace & Create some VM's 
### STORAGE 
### DEMO . Static Web Hosting 
  + Azure Storage Explorer 
### NETWORK & CDN 

## All the Services 

### All the Services Introduction 
### DATABASES 
### AI & COGNITIVE SERVICES 
### BIG DATA & ANALYTICS 
  + Azure Analysis Services 
### DEMO - Making a chatbot
  + Create Slack Workspace 
  + Create a Slack App 
  + LUIS 
### WEB AND MOBILE 
### DEMO - Logic Apps - Understand Twitter Emotion
### INTERNET OF THINGS 
  + Event Hubs v's IOT Hubs 
### MANAGEMENT & MONITORING
### SECURITY & IDENTITY

## Finishing Up 

### Azure Roadmap 
  + Azure Roadmap 
  + Azure Updates 
  + Azure Blog 
### What you've learned ? 
### Whats Next ? 
  + Exam Resource - 70-532 - Developing Azure Solutions 
  + Exam Resources - 70-533 - Implementing Azure Infrastructure Solutions 
  + Exam Resources - 70-535 - Architecture Azure Solutions 
