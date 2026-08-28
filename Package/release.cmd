del "*.nupkg"
"..\..\oqtane.framework\oqtane.package\nuget.exe" pack Ncube.Theme.PlanetMinistries.nuspec 
XCOPY "*.nupkg" "..\..\oqtane.framework\Oqtane.Server\Packages\" /Y
