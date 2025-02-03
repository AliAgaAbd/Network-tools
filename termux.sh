#!/bin/bash
pkg install wget -y
wget https://raw.githubusercontent.com/AliAgaAbd/Network-tools/refs/heads/main/linux-x64.7z -O /tmp/linux-x64.7z
pkg install p7zip -y
7z x /tmp/linux-x64.7z -o/tmp/
cd /tmp/linux-x64
./Program
