@echo off
goto check_Permissions

:check_Permissions
    net session >nul 2>&1
    if %errorLevel% == 0 (
        rem We are administrator.
    ) else (
        echo Failure: Current permissions inadequate. Please run as administrator.
	pause >nul
	exit
    )

rem cd %SystemRoot%\system32\drivers\etc\

if exist %SystemRoot%\system32\drivers\etc\hosts.bak (
move %SystemRoot%\system32\drivers\etc\hosts.bak %SystemRoot%\system32\drivers\etc\hosts > nul
echo Done.
) else (
echo Your host files does not seem to be modified. Aborting. )

pause >nul