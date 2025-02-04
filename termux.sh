#!/data/data/com.termux/files/usr/bin/sh
pkg update -y
pkg install -y wget curl
if ! command -v dotnet &> /dev/null; then
    echo "dotnet not installed! Installing dotnet 8.0..."
    wget https://download.visualstudio.microsoft.com/download/pr/d35f2de9-2d13-47c9-aeae-d0834a3d40f2/122d0e570da870e52cd60784d9e24be7/dotnet-sdk-8.0.100-linux-x64.tar.gz -O dotnet.tar.gz
    mkdir -p $HOME/dotnet
    tar -xzvf dotnet.tar.gz -C $HOME/dotnet
    export PATH=$PATH:$HOME/dotnet
    echo "dotnet 8.0 installed successfully!"
else
    echo "dotnet is already installed!"
fi
mkdir -p ~/cs_project && cd ~/cs_project || exit
curl -L -o Program.cs "https://raw.githubusercontent.com/AliAgaAbd/Network-tools/main/Program.cs"
dotnet new console -o my_project --force
mv Program.cs my_project/
cd my_project || exit
dotnet run Program.cs
