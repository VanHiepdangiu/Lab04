@echo off
chcp 65001 >nul
title Push lab04 len GitHub - VanHiepdangiu (2410900035)
echo ================================================
echo   DAY CODE LEN GITHUB - Lab 04 - lab04
echo   SV: Nguyen Van Hiep - MSSV: 2410900035
echo ================================================
echo.

REM Kiem tra git
where git >nul 2>&1
if errorlevel 1 (
    echo KHONG TIM THAY GIT! Hay cai Git: https://git-scm.com/download/win
    pause
    exit /b
)
echo OK - co Git.

set /p REPO="Nhap ten repo GitHub (VD: Lab04): "
if "%REPO%"=="" set REPO=Lab04

cd /d "%~dp0"

REM Xoa .git cu neu co
if exist .git rmdir /s /q .git

git init
git add .
git commit -m "Lab 04: Controller nang cao - Account/Profile + Route - Nguyen Van Hiep (2410900035)"
git branch -M main

echo.
echo ================================================
echo   TAO REPO TREN GITHUB TRUOC (Bang web):
echo   1. https://github.com/new
echo   2. Ten repo: %REPO%
echo   3. De Public, KHONG tick "Add a README"
echo   4. Create repository
echo ================================================
echo.

set /p TOKEN="Dan token GitHub cua anh vao day: "

git remote add origin https://VanHiepdangiu:%TOKEN%@github.com/VanHiepdangiu/%REPO%.git
git push -u origin main

if errorlevel 1 (
    echo.
    echo LOI PUSH! Kiem tra lai token hoac ten repo.
    pause
    exit /b
)

echo.
echo ================================================
echo   DONE! Link: https://github.com/VanHiepdangiu/%REPO%
echo ================================================
pause
