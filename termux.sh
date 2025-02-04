#!/bin/bash
if ! command -v git &> /dev/null; then
    echo "git is not installed. Installing..."
    sudo pacman -S git --noconfirm
fi
if ! command -v dotnet &> /dev/null; then
    echo ".NET SDK is not installed. Installing..."
    sudo pacman -S dotnet-sdk --noconfirm
fi
echo "Cloning project from GitHub..."
git clone https://github.com/AliAgaAbd/Network-tools.git
cd Network-tools || exit
dotnet restore
dotnet run
echo "Project started successfully!"
