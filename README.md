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
