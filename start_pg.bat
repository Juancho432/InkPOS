@echo off
set BIN_PATH=%~dp0PostgreSQL\bin
set DATA_PATH=%~dp0PostgreSQL\data
set LOG_PATH=%~dp0pg_log.txt

echo Iniciando servidor PostgreSQL...
"%BIN_PATH%\pg_ctl.exe" -D "%DATA_PATH%" -l "%LOG_PATH%" start

echo Servidor iniciado. Log en pg_log.txt
