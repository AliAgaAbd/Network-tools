#!/data/data/com.termux/files/usr/bin/sh
tpkg update && pkg install -y dotnet
mkdir -p ~/cs_project && cd ~/cs_project
curl -o Program.cs https://raw.githubusercontent.com/AliAgaAbd/Network-tools/refs/heads/main/Program.cs
dotnet new console -o my_project --force
mv Program.cs my_project/
cd my_project
dotnet run
