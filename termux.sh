#!/bin/bash
pkg update && pkg upgrade
pkg install wget
pkg install p7zip
wget https://raw.githubusercontent.com/AliAgaAbd/Network-tools/refs/heads/main/linux-x64.7z -O myproject.7z
7z x myproject.7z -omyproject
cd myproject
./Program
