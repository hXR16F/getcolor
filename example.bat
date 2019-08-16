@echo off
setlocal EnableDelayedExpansion
cd "bin/Debug"
for %%a in (0 1 2 3 4 5 6 7 8 9 a b c d e f) do (
	for %%b in (0 1 2 3 4 5 6 7 8 9 a b c d e f) do (
		cls
		color %%a%%b
		for /f "tokens=1,2,3 delims=:" %%i in ('call getcolor.exe') do (
			echo.
			echo  Code: %%i
			set cl=%%i&echo  Color only: !cl:~2,2!
			echo  Background name: %%j
			echo  Foreground name: %%k
		)
		echo.&echo  Press any key to continue . . .&pause >nul
	)
)