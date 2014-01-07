@echo off
rem ******************************************************
rem * Enhanced Steam Standalone launcher.                *
rem *                                                    *
rem * Author: 7heo .github.com/@7heo.tk                  *
rem * Date: 2013/01/07                                   *
rem *                                                    *
rem ******************************************************

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

if exist %SystemRoot%\system32\drivers\etc\hosts.bak (
	move %SystemRoot%\system32\drivers\etc\hosts.bak %SystemRoot%\system32\drivers\etc\hosts > nul
	taskkill /F /IM nginx.exe > nul
	taskkill /F /IM rinetd.exe > nul
	echo Disabled.
) else (
	copy %SystemRoot%\system32\drivers\etc\hosts %SystemRoot%\system32\drivers\etc\hosts.bak >nul
	echo 127.0.0.200 store.steampowered.com >> %SystemRoot%\system32\drivers\etc\hosts
	echo 127.0.0.201 steamcommunity.com >> %SystemRoot%\system32\drivers\etc\hosts
	start %~dp0\bin\nginx.exe -p %~dp0
	start /min %~dp0\bin\rinetd.exe -c %~dp0\conf\rinetd.conf
	echo WARNING: A CMD WINDOWS HAS BEEN OPENED MINIMIZED.
	echo          DO NOT CLOSE IT OR ENHANCED STEAM WON'T WORK.
	echo Enabled.
)

pause >nul