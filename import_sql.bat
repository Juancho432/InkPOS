@echo off
set BIN_PATH=%~dp0PostgreSQL\bin
set SQL_FILE=%~dp0InkPosDB.sql
set USER=postgres

echo Importando archivo SQL a la base de datos postgres...
"%BIN_PATH%\psql.exe" -U %USER% -d postgres -f "%SQL_FILE%"

echo Base de datos importada correctamente.
pause
