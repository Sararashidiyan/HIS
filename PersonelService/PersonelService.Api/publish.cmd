@echo off
:: ============================================
:: Publish ASP.NET Core project to Desktop
:: Usage: publish <version>
:: Example: publish 1.0
:: ============================================

:: Validate argument
if "%~1"=="" (
    echo Version was not specified!
    echo Usage: publish ^<version^>
    goto :END
)

:: Set publish path on Desktop
set publishpath=%userprofile%\Desktop\MyAspNetApp.v%1

:: Clean old folder if exists
if exist "%publishpath%" (
    echo Removing old publish folder...
    rd /s /q "%publishpath%"
)

:: Run dotnet publish
echo Publishing project...
dotnet publish -c Release -o "%publishpath%"

echo:
echo ✅ Publish completed!
echo Output folder: %publishpath%

:END
