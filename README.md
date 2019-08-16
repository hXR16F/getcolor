# GetColor
GetColor is a plugin for batch files. You can get current background and foreground color from active cmd window.

# Usage

Code #1:

```batchfile
@echo off
color 1f
call getcolor.exe
pause
```

Output:

```
0x1f:DarkBlue:White
Press any key to continue . . .
```

Code #2:

```batchfile
@echo off
color 1f
for /f "tokens=1,2,3 delims=:" %%i in ('call getcolor.exe') do (
  echo %%i
  echo %%j
  echo %%k
)
pause
```

Output:

```
0x1f
DarkBlue
White
Press any key to continue . . .
```

Code #3:

```batchfile
@echo off
setlocal EnableDelayedExpansion
color 1f
for /f "tokens=1,2,3 delims=:" %%i in ('call getcolor.exe') do (
  echo.
  echo  Code: %%i
  set cl=%%i
  echo  Color only: !cl:~2,2!
  echo  Background name: %%j
  echo  Foreground name: %%k
)
echo.
echo  Press any key to continue . . .
pause >nul
```

Output:

```
0x1f
1f
DarkBlue
White
Press any key to continue . . .
```
