#!/bin/bash
if ! command -v curl &> /dev/null; then
    echo "curl نصب نشده است. در حال نصب..."
    sudo pacman -S curl --noconfirm
fi
if ! command -v dotnet &> /dev/null; then
    echo ".NET SDK نصب نشده است. در حال نصب..."
    sudo pacman -S dotnet-sdk --noconfirm
fi
if [ ! -d "my_project" ]; then
    dotnet new console -o my_project --force
fi
mv Program.cs my_project/
cd my_project || exit
dotnet run
