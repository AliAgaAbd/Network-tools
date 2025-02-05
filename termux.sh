#!/bin/bash
pkg update -y && pkg upgrade -y
pkg install -y wget curl
wget https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.deb
dpkg -i packages-microsoft-prod.deb
apt update
apt install -y dotnet-sdk-8.0
wget -O Program.cs "https://raw.githubusercontent.com/AliAgaAbd/Network-tools/main/Program.cs"
dotnet new console -o my_project --force
mv Program.cs my_project/
cd my_project || exit
dotnet run
echo "Program executed successfully!"
