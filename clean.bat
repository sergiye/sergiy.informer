@echo off

rmdir /s /q .vs
rmdir /s /q .idea

rmdir /s /q .\currency.watcher\obj
del /S ".\currency.watcher\bin\*.dll"
del /S ".\currency.watcher\bin\*.pdb"
del /S ".\currency.watcher\bin\*.xml"
