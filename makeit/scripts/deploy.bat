@echo off
REM Simple legacy deploy - copies artifacts to C:\inetpub\wwwroot\legacy
echo Deploy started...
xcopy /E /Y "..\asp_classic\*.*" "C:\inetpub\wwwroot\legacy\"
echo Deploy finished.
