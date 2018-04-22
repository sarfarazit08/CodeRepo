$tempPath = Join-Path $env:TEMP "dnvminstall"
$dnvmPs1Path = Join-Path $tempPath "dnvm.ps1"
$dnvmCmdPath = Join-Path $tempPath "dnvm.cmd"

Write-Host "Using temporary directory: $tempPath"
if (!(Test-Path $tempPath)) { md $tempPath | Out-Null }

$webClient = New-Object System.Net.WebClient
$webClient.Proxy = [System.Net.WebRequest]::DefaultWebProxy
$webClient.Proxy.Credentials = [System.Net.CredentialCache]::DefaultNetworkCredentials

Write-Host "Downloading DNVM.ps1 to $dnvmPs1Path"
$webClient.DownloadFile('https://raw.githubusercontent.com/aspnet/Home/dev/dnvm.ps1', $dnvmPs1Path)

Write-Host "Downloading DNVM.cmd to $dnvmCmdPath"
$webClient.DownloadFile('https://raw.githubusercontent.com/aspnet/Home/dev/dnvm.cmd', $dnvmCmdPath)

Write-Host "Installing DNVM"
Start-Process -Wait -FilePath $dnvmCmdPath -ArgumentList setup 

Write-Host "Installing latest DNX"
Start-Process -Wait -FilePath $dnvmCmdPath -ArgumentList "install -g -arch x64 1.0.0-rc1-update1"

Write-Host "Setting DNX RC1 to default"
Start-Process -Wait -FilePath $dnvmCmdPath -ArgumentList "use -version 1.0.0-rc1-update1"
Start-Process -Wait -FilePath $dnvmCmdPath -ArgumentList "alias -version 1.0.0-rc1-update1 -n default"