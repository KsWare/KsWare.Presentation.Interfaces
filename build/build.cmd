@echo off
cd..
path=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin;%path%
path="C:\Users\KayS\Downloads\nuget.exe";%path%
rd /S /Q src\KsWare.Presentation.Interfaces\bin
nuget restore src\KsWare.Presentation.Interfaces.sln
msbuild "src\KsWare.Presentation.Interfaces.sln" /verbosity:normal /p:GeneratePackageOnBuild=false -t:Rebuild -p:Configuration=Release
dotnet pack "src\KsWare.Presentation.Interfaces\KsWare.Presentation.Interfaces.csproj" --configuration Release --output "build\Temp" --no-build
pause