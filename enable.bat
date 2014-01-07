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

if exist %SystemRoot%\system32\drivers\etc\hosts.bak (
	echo Your host files seems to be already modified. Aborting.
) else (
	copy %SystemRoot%\system32\drivers\etc\hosts %SystemRoot%\system32\drivers\etc\hosts.bak >nul
	echo 127.0.0.200 store.steampowered.com >> %SystemRoot%\system32\drivers\etc\hosts
	echo 127.0.0.201 steamcommunity.com >> %SystemRoot%\system32\drivers\etc\hosts
	echo Done.
)

pause >nul