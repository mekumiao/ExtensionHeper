dotnet pack -p:PackageVersion=1.0.1

dotnet nuget push .\bin\Debug\ExtensionHelper.Core.1.0.1.nupkg -k oy2jfy4h2v4cw3oxb7qqya7dr2vhyd3ulbahapgvaj2ycm -s http://onlyoned.com:9081

pause