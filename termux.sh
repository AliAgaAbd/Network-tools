pkg upgrade
pkg install proot-distro
proot-distro install ubuntu
proot-distro login ubuntu
apt update && apt upgrade
apt dist-upgrade
apt install dotnet-sdk-8.0
apt install dotnet-runtime-8.0
apt install wget
apt install curl
mkdir -p my_project
wget -O my_project/Program.cs "https://raw.githubusercontent.com/AliAgaAbd/Network-tools/main/Program.cs"
cd my_project
dotnet new console --force
dotnet run
echo "Program executed successfully!"
