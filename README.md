# GetColor
GetColor is a plugin for batch files (and not only). You can get current background and foreground color from active cmd window.

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
  echo %%i
  set cl=%%i
  echo !cl:~2,2!
  echo %%j
  echo %%k
)
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
