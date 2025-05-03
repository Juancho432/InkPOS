@echo off
set BIN_PATH=%~dp0PostgreSQL\bin
set DATA_PATH=%~dp0PostgreSQL\data

echo Deteniendo servidor PostgreSQL...
"%BIN_PATH%\pg_ctl.exe" -D "%DATA_PATH%" stop

echo Servidor detenido.
