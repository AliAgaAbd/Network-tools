#!/data/data/com.termux/files/usr/bin/sh
pkg update -y && pkg install -y dotnet
mkdir -p ~/cs_project && cd ~/cs_project || exit
curl -L -o Program.cs "https://raw.githubusercontent.com/AliAgaAbd/Network-tools/main/Program.cs"
if ! command -v dotnet &> /dev/null; then
    echo "dotnet not installed!"
    exit 1
fi
dotnet new console -o my_project --force
mv Program.cs my_project/
cd my_project || exit
dotnet run
