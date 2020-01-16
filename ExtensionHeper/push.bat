
devenv "..\ExtensionHeper.sln" /build Release /project "ExtensionHeper.csproj"

nuget pack ExtensionHeper.csproj -Version 1.0.0.3

nuget push .\*.nupkg -Source http://onlyoned.com:9081 -ApiKey oy2jfy4h2v4cw3oxb7qqya7dr2vhyd3ulbahapgvaj2ycm

pause