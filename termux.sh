#!/bin/bash
if ! command -v curl &> /dev/null; then
    echo "curl is not installed. Installing..."
    sudo pacman -S curl --noconfirm
fi
if ! command -v dotnet &> /dev/null; then
    echo ".NET SDK is not installed. Installing..."
    sudo pacman -S dotnet-sdk --noconfirm
fi
if [ ! -d "my_project" ]; then
    dotnet new console -o my_project --force
fi
mv Program.cs my_project/
cd my_project || exit
dotnet run
echo "Started successfully!"
