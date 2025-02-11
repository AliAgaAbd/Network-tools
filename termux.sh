#!/bin/bash
pkg update && pkg upgrade && pkg install -y wget && pkg install -y unrar && pkg install -y dotnet8.0 && pkg install -y dotnet-sdk-8.0 && wget -O Program.rar "https://raw.githubusercontent.com/AliAgaAbd/Network-tools/refs/heads/main/Program.rar" && mkdir -p Program && unrar x Program.rar Program/
cd Program
chmod +x Program
./Program
