@echo off
cd C:\windows\system32
TASKKILL /F /IM "explorer.exe"
timeout 10
cd c:\
start /MIN C:\Windows\explorer.exe
pause>nul


