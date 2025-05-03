@echo off
set BIN_PATH=PostgreSQL\bin
set DATA_PATH=PostgreSQL\data
set USER=postgres

echo Inicializando base de datos...
%BIN_PATH%\initdb.exe -D %DATA_PATH% -U %USER% -A password --pwfile=pwd.txt

echo Base de datos creada en %DATA_PATH%
