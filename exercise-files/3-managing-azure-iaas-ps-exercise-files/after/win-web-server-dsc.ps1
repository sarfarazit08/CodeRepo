configuration WebApp 
{ 
    Import-DscResource -Module xWebAdministration     
    Import-DSCResource -Module xPSDesiredStateConfiguration 
    Import-DSCResource -Module xNetworking 
    
    Node localhost {       

        WindowsFeature IIS  
        {  
            Ensure          = "Present"
            Name            = "Web-Server"
        }  

        WindowsFeature IISManagement  
        {  
            Ensure          = "Present"
            Name            = "Web-Mgmt-Console"
            DependsOn       = "[WindowsFeature]IIS"
        } 
  
        xWebsite DefaultSite   
        {  
            Ensure          = "Present"
            Name            = "Default Web Site"
            State           = "Stopped"
            PhysicalPath    = "C:\inetpub\wwwroot" 
            DependsOn       = "[WindowsFeature]IIS"
        }  
        
        Script IisConfigUnlock
        {
            GetScript = 
            {
                return @{ Result = "unlocked" }
            }  
            TestScript = 
            { 
                $false
            }
            SetScript = 
            {
                & c:\windows\system32\inetsrv\appcmd.exe unlock config /section:system.webServer/handlers
            }            
            DependsOn       = "[WindowsFeature]IIS" 
        }  

        xRemoteFile HttpHandlerDownload 
        {  
            Uri             = "http://go.microsoft.com/fwlink/?LinkId=690721"
            DestinationPath = "C:\setup\httpPlatformHandler_amd64.msi"
            DependsOn       = "[WindowsFeature]IIS" 
        } 

        Package HttpHandlerInstall
        {
            Ensure = "Present"
            Path = "C:\setup\httpPlatformHandler_amd64.msi"
            Name = "Microsoft HTTP Platform Handler 1.2"
            ProductId = "49FE726A-F8A3-426F-9448-337D47E355FA"
            DependsOn       = "[xRemoteFile]HttpHandlerDownload"
        }

        xRemoteFile DotNetDownload
        {  
            Uri             = "##TODO path/to/setup-win-web-server/setup-dotnet-core.ps1 ##"
            DestinationPath = "C:\setup\setup-dotnet-core.ps1"
        }

        Script DotNetInstall
        {   
            GetScript =
            {
                return @{ Result = ("RC1 installed: {0}" -f (Test-Path "C:\ProgramData\Microsoft DNX\runtimes\dnx-clr-win-x64.1.0.0-rc1-update1\bin\dnx.exe")) }
            }      
            TestScript = 
            { 
                return Test-Path "C:\ProgramData\Microsoft DNX\runtimes\dnx-clr-win-x64.1.0.0-rc1-update1\bin\dnx.exe"
            }
            SetScript = 
            {
                & C:\setup\setup-dotnet-core.ps1
            }              
            DependsOn       = "[xRemoteFile]DotNetDownload"          
        }
        
        xRemoteFile WebAppDownload
        {  
            Uri             = "##TODO path/to/setup-win-web-server/webapp-1.0.0.0.zip ##"
            DestinationPath = "C:\setup\web-app.zip"
            DependsOn       = "[WindowsFeature]IIS" 
        } 
        
        Archive WebAppExtract
        {              
            Path = "C:\setup\web-app.zip"
            Destination = "c:\inetpub"
            DependsOn = "[xRemoteFile]WebAppDownload"            
        }
        
        xWebAppPool WebAppAppPool   
        {  
            Ensure          = "Present"  
            Name            = "web-app" 
            State           = "Started"
            managedRuntimeVersion = ""
            DependsOn       = "[Archive]WebAppExtract"
        }    

        xWebsite WebAppWebSite   
        {  
            Ensure          = "Present"  
            Name            = "web-app" 
            State           = "Started"
            PhysicalPath    = "C:\inetpub\webapp\wwwroot"
            ApplicationPool = "web-app"
            BindingInfo = MSFT_xWebBindingInformation
                    {
                        Port = '8080'
                        IPAddress = '*'
                        Protocol = 'HTTP'
                    }
            DependsOn = "[xWebAppPool]WebAppAppPool"
        }

        xFirewall Http8080
        {
            Name         = "Htpp-8080"
            DisplayName  = "Htpp-8080"
            Ensure       = "Present"
            Action       = "Allow"
            Direction    = "Inbound"
            LocalPort    = ("8080")
            Protocol     = "TCP"
        }         
    }
}