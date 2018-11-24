echo off
cd..
echo ################################ >> github.txt
echo %date% %time% >> github.txt
git pull origin >> github.txt
