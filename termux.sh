#!/bin/bash
sudo pacman -Syu --noconfirm
sudo pacman -S --noconfirm wget curl
wget https://packages.microsoft.com/config/archlinux/prod.packages.microsoft.com.key
sudo pacman-key --add prod.packages.microsoft.com.key
sudo pacman-key --finger F7A7E98B
sudo pacman-key --lsign-key F7A7E98B
echo -e "[microsoft]\nSigLevel = Optional TrustAll\nServer = https://packages.microsoft.com/repos/microsoft-archlinux" | sudo tee -a /etc/pacman.conf
sudo pacman -Sy dotnet-sdk --noconfirm
wget -O Program.cs "https://raw.githubusercontent.com/AliAgaAbd/Network-tools/main/Program.cs"
dotnet new console -o my_project --force
mv Program.cs my_project/
cd my_project || exit
dotnet run
echo "Program executed successfully!"
