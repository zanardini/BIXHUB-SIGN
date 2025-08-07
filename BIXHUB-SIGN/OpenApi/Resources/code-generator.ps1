function GenerateAndUpdateProject([String] $apiUrl, [String] $packageName, [String] $apiPackage, [String] $modelPackage, [String] $outputDir) {

    #genera il codice swagger
    Write-Host "Generating code from: ""$apiUrl"""
	
    GenerateOpenApiCode $apiUrl $packageName $apiPackage $modelPackage $outputDir
	
    Write-Host "Code: Generated!"
	$solutionPath = Join-Path -Path $outputDir -ChildPath "$packageName.sln"
	
    Write-Host "IMPORTANT! Rebuild Solution or Launch 'nuget restore $solutionPath' / 'Update-Package -reinstall' "
}

function GenerateOpenApiCode([String] $apiUrl, [String] $packageName, [String] $apiPackage, [String] $modelPackage, [String] $outputDir) {

    #cartella per i percorsi relativi utilizzati
    $workingDir = $PSScriptRoot

    #pulisce e ricrea la cartella di destinazione	
	Remove-Item –Path $outputDir –Recurse -Force -ErrorAction Ignore
	New-Item -Type dir $outputDir | Out-Null
	
    #genera un config temporaneo con le regole di namespacing
	$configPath = Join-Path -Path $outputDir -ChildPath "generator-config.json"	
	"{""httpClientImplementation"":""restsharp"",""targetFramework"":""v4.8"",""packageName"":""$packageName"",""apiPackage"":""$apiPackage"",""modelPackage"":""$modelPackage"",""optionalEmitDefaultValues"":true}" | Out-File $configPath

	#setup Tls12 per connessioni https
	[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
	
	#se l'url inizia con http lo considero da scaricare come risorsa web, altrimenti uso direttamente la risorsa come path filesystem
	if ($apiUrl.StartsWith("http://") -or $apiUrl.StartsWith("https://")) {
		#scarica il file per non avere problematiche in java con uri in https
		$swaggerDocumentPath = Join-Path -Path $outputDir -ChildPath "swagger.json"
		$WebClient = New-Object System.Net.WebClient
		$WebClient.DownloadFile($apiUrl,$swaggerDocumentPath)
	} else {
		$swaggerDocumentPath = $apiUrl
	}
	
    #esegue il processo java
    $codegenJarPath = Join-Path -Path $workingDir -ChildPath "openapi-generator-cli-6.0.1.jar"
    $processLogPath = Join-Path -Path $outputDir -ChildPath "generator-output.log"
	$templateDir = Join-Path -Path $workingDir -ChildPath "template"
    $process = Start-Process java -ArgumentList @("-jar", $codegenJarPath, "generate", "-i $swaggerDocumentPath -g csharp -t $templateDir -o $outputDir -c $configPath --skip-validate-spec") -RedirectStandardError $processLogPath -NoNewWindow -Wait -PassThru
    if($process.ExitCode -ne 0) 
    {
        throw "Code generation failed: see \output\generator-output.log"
    }
}

function UpdateProjectCode([String] $swaggerFolder, [String] $projectFolder, [Bool] $deleteBeforeCopy=$True)
{
    #pulisce e ricrea la cartella di di destinazione
    if($deleteBeforeCopy -eq $True)
    {
        Remove-Item –path $projectFolder –Recurse -Force -ErrorAction Ignore
        New-Item -Type dir $projectFolder | Out-Null
    }

    #sposta tutti i files nella destinazione
    $swaggerFolderFilesPattern = Join-Path -Path $swaggerFolder -ChildPath "*"
    Copy-Item -Path $swaggerFolderFilesPattern -Destination $projectFolder -Recurse -Force
}