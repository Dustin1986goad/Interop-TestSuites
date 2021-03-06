$script:ErrorActionPreference = "Stop"
$domain = .\Get-ConfigurationPropertyValue.ps1 Domain
$userName = .\Get-ConfigurationPropertyValue.ps1 UserName
$password = .\Get-ConfigurationPropertyValue.ps1 Password
$computerName = .\Get-ConfigurationPropertyValue.ps1 SUTComputerName

$requestUrl= .\Get-ConfigurationPropertyValue.ps1 TargetServiceUrl

$securePassword = $securePassword = ConvertTo-SecureString $password -AsPlainText -Force
$credential = new-object Management.Automation.PSCredential(($domain+"\"+$userName),$securePassword)

#invoke function remotely
$ret = invoke-command -computer $computerName -Credential $credential -scriptblock {
  param(
       [string]$currentDoclibraryName,
       [string]$requestUrl,
       [string]$uploadedfilesUrls
  )
  $script:ErrorActionPreference = "Stop"
  [void][System.Reflection.Assembly]::LoadWithPartialName("Microsoft.SharePoint")
  try
  {    
      $spSites = new-object Microsoft.SharePoint.SPSite "$requestUrl"
      $spWeb =  $spSites.RootWeb
      $folderitems = $spWeb.Folders
      $listFolder = $folderitems[$currentDoclibraryName]
      $ErrorCounter = 0
      if($listFolder -ne $null)
      {
          $Files = $listFolder.Files
          $urlsArray = $uploadedfilesUrls.Split(',')
          foreach($urlItem in $urlsArray)
          {
              try
              {
                  $Files.Delete($urlItem);
              }
              catch
              {
                  $ErrorCounter ++
              }
          }
      }
      $ret = $ErrorCounter -eq 0
  }
  catch
  {
      throw $error[0]
  }
  finally
  {
      if($spSites -ne $null)
      {
          $spSites.Dispose()
      }
  }
  return $ret
} -argumentlist $currentDoclibraryName, $requestUrl, $uploadedfilesUrls

return $ret