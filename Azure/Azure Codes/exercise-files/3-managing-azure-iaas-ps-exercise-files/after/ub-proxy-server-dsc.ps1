Configuration WebProxy
{     
    Import-DscResource -Module nx   
    
    Node localhost {  

        nxPackage Nginx  
        {  
            Ensure          = "Present"
            Name            = "nginx"
            PackageManager  = "apt"
        } 

        nxFile DefaultConf 
        {
            Ensure = "absent"
            DestinationPath = '/etc/nginx/sites-enabled/default'
            DependsOn = '[nxPackage]Nginx'
        }

        nxFile ProxyConf 
        {
            SourcePath = "##TODO path/to/setup-ub-proxy-server/nginx.conf ##"
            DestinationPath = '/etc/nginx/sites-available/proxy'
            DependsOn = '[nxPackage]Nginx'
        }  

        nxScript EnableProxy
        {
            DependsOn = '[nxFile]ProxyConf'
            GetScript = @' 
#!/bin/bash
ls /etc/nginx/sites-enabled/ | wc -l 
'@

            TestScript = @'
#!/bin/bash
if [ -e "/etc/nginx/sites-enabled/proxy" ]
then
    exit 0
else 
    exit 1
fi
'@

            SetScript = @'
#!/bin/bash
ln -s /etc/nginx/sites-available/proxy /etc/nginx/sites-enabled
service nginx restart
'@
        }

        nxService NginxStart
        {
            Name = "nginx"
            State = "Running"
            Enabled = $true
            Controller = "init"
            DependsOn = '[nxScript]EnableProxy'
        }
    }
}

#build MOF:
WebProxy -OutputPath "m3"