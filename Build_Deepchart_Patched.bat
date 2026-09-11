@echo off
chcp 65001 >nul
echo ============================================================
echo   Deepchart Trading Platform - License-Patched Build
echo ============================================================
echo.

setlocal enabledelayedexpansion
cd /d "%~dp0source_deepchart"

where dotnet >nul 2>nul
if %ERRORLEVEL% NEQ 0 (
    echo [ERROR] .NET SDK not found!
    echo Please install .NET 10 SDK from https://dotnet.microsoft.com/download
    echo (Visual Studio 2022 17.12+ includes it by default)
    pause
    exit /b 1
)

echo [1/3] Restoring NuGet packages...
dotnet restore Deepchart.csproj
if %ERRORLEVEL% NEQ 0 (
    echo Restore FAILED
    pause
    exit /b 1
)

echo.
echo [2/3] Building Release x64 EXE...
dotnet build Deepchart.csproj -c Release -p:Platform=x64 --no-restore
if %ERRORLEVEL% NEQ 0 (
    echo.
    echo Build FAILED with %ERRORLEVEL% - checking if errors are only pre-existing decompile issues...
    echo.
    echo NOTE: If you see errors only in files OTHER THAN:
    echo   - License/Status.cs
    echo   - VolAnalysis/Cryptography/SeparatedCommandEncryptor.cs (only lines around 1621-1625 matter)
    echo   - VolAnalysis/Cryptography/OperationalEncryptor.cs
    echo Then the LICENSE PATCH is CORRECT. The other errors are from decompilation.
    echo.
    echo To build anyway despite pre-existing errors, uncomment the line below:
    REM dotnet build Deepchart.csproj -c Release -p:Platform=x64 --no-restore -p:ContinueOnError=WarnAndContinue
    pause
    exit /b 1
)

echo.
echo [3/3] Locating output EXE...
set OUTDIR="%~dp0source_deepchart\bin\x64\Release\net10.0-windows"
if not exist %OUTDIR% set OUTDIR="%~dp0source_deepchart\bin\Release\net10.0-windows"
dir /b %OUTDIR%\Deepchart.exe 2>nul
if %ERRORLEVEL% NEQ 0 (
    dir /s /b "%~dp0source_deepchart\bin\Deepchart.exe"
) else (
    echo SUCCESS: Deepchart.exe is at %OUTDIR%
)

echo.
echo ============================================================
echo  Build complete! License bypass installed in EXE.
echo  License.Status ^> Always returns PERMANENT / ACTIVATED
echo  GetLicense()      ^> Returns valid non-null license
echo  [LicenseProvider] ^> Removed (auto-validation skipped)
echo ============================================================
pause
