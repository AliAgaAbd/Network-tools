#!/bin/bash
pkg update && pkg upgrade
pkg install wget
pkg install p7zip
pkg install wget p7zip
wget https://raw.githubusercontent.com/AliAgaAbd/Network-tools/refs/heads/main/linux-x64.7z -O myproject.7z
7z x myproject.7z -O myproject
cd myproject
./Program
