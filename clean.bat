@echo off
REM ============================================================================
REM @file        clean.bat
REM @project     Pulse Protocol
REM
REM @copyright   Copyright (C) 2026 DigiPen Institute of Technology.
REM              Reproduction or disclosure of this file or its contents without the
REM              prior written consent of DigiPen Institute of Technology is prohibited.
REM ============================================================================

setlocal

REM Remove build directory in the root
if exist build (
    echo Removing CMakeCache file...
    del /F /Q "build\CMakeCache.txt"
    rmdir /S /Q build
)

REM Remove build directory in game
pushd game >nul
if exist build (
    echo Removing build directory...
    rmdir /S /Q build
)
popd >nul

endlocal
