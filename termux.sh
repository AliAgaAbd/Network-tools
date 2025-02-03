#!/bin/bash
pkg update
pkg upgrade
pkg install wget
pkg install p7zip
pkg install wget p7zip -y
wget https://raw.githubusercontent.com/AliAgaAbd/Network-tools/refs/heads/main/linux-x64.7z -O /tmp/linux-x64.7z
7z x /tmp/linux-x64.7z -o/tmp/
cd /tmp/linux-x64 || exit
./Program
