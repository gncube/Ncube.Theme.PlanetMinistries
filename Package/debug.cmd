@echo off
REM Define the target directory path
SET TARGET_DIR="..\..\oqtane.framework\Oqtane.Server\bin\Debug\net9.0\"

REM Check if the local framework folder exists
IF NOT EXIST %TARGET_DIR% (
    echo [INFO] Oqtane framework local folder not found at: %TARGET_DIR%
    echo [INFO] Skipping automated local asset deploy. The build will complete successfully.
    exit /b 0
)

REM If the directory exists, run the original copy commands
XCOPY "..\Client\bin\Debug\net9.0\Ncube.Theme.PlanetMinistries.Client.Oqtane.dll" %TARGET_DIR% /Y
XCOPY "..\Client\bin\Debug\net9.0\Ncube.Theme.PlanetMinistries.Client.Oqtane.pdb" %TARGET_DIR% /Y
XCOPY "..\Client\wwwroot\*" "..\..\oqtane.framework\Oqtane.Server\wwwroot\" /Y /S /I