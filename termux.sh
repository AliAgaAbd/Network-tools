#!/bin/bash
pkg update && pkg upgrade && pkg install -y wget && pkg install -y unrar && pkg install -y dotnet8.0 && pkg install dotnet-sdk-8.0 && wget -O my_project.rar "https://raw.githubusercontent.com/AliAgaAbd/Network-tools/refs/heads/main/Program.rar" && mkdir -p my_project && unrar x my_project.rar my_project/
cd my_project
chmod +x Program
./Program
