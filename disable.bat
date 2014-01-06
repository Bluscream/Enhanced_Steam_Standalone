@echo off
goto check_Permissions

:check_Permissions
    echo Administrative permissions required. Detecting permissions...

    net session >nul 2>&1
    if %errorLevel% == 0 (
        echo Success: Administrative permissions confirmed.
    ) else (
        echo Failure: Current permissions inadequate.
	pause >nul
	exit
    )

echo #file wiped out > %SystemRoot%\system32\drivers\etc\hosts

echo Done.
pause >nul