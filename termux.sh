#!/bin/bash
pkg update && pkg upgrade
pkg install Wget
pkg install p7zip
Wget https://raw.githubusercontent.com/AliAgaAbd/Network-tools/refs/heads/main/linux-x64.7z -O myproject.7z
7z x myproject.7z -o myproject
cd myproject
./Program
