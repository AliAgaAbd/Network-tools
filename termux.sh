pkg upgrade
pkg install proot-distro -y
proot-distro install ubuntu -y
proot-distro login ubuntu -y
apt update && apt upgrade -y
apt dist-upgrade -y
apt install dotnet-sdk-8.0 -y
apt install dotnet-runtime-8.0 -y
apt install wget -y
apt install curl -y
mkdir -p my_project
wget -O my_project/Program.cs "https://raw.githubusercontent.com/AliAgaAbd/Network-tools/main/Program.cs"
cd my_project
dotnet new console --force
dotnet run
echo "Program executed successfully!"