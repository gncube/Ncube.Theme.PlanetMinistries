@echo off
setlocal enabledelayedexpansion

if exist "*.nupkg" del /f /q "*.nupkg" 2>nul

set "LOCAL_NUGET=..\..\oqtane.framework\oqtane.package\nuget.exe"
set "TARGET_DIR=..\..\oqtane.framework\Oqtane.Server\Packages"
set "NUSPEC=Ncube.Theme.PlanetMinistries.nuspec"

if not exist "%NUSPEC%" (
    echo [ERROR] Nuspec file "%NUSPEC%" not found in %CD%
    exit /b 1
)

if exist "%LOCAL_NUGET%" (
    echo [INFO] Using local framework NuGet.
    "%LOCAL_NUGET%" pack "%NUSPEC%"
) else (
    where nuget >nul 2>nul
    if !ERRORLEVEL! equ 0 (
        echo [INFO] Using global NuGet.
        nuget pack "%NUSPEC%"
    ) else (
        echo [WARNING] nuget.exe not found. Skipping NuGet package creation.
        exit /b 0
    )
)

if %ERRORLEVEL% neq 0 (
    echo [ERROR] nuget pack failed.
    exit /b %ERRORLEVEL%
)

if exist "%TARGET_DIR%" (
    echo [INFO] Copying package to local Oqtane framework...
    xcopy "*.nupkg" "%TARGET_DIR%\" /y
)

exit /b 0