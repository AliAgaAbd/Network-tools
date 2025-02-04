#!/bin/bash
install_git() {
    if ! command -v git &> /dev/null; then
        echo "git is not installed. Installing..."
        sudo pacman -S git --noconfirm
    fi
}
install_dotnet() {
    if ! command -v dotnet &> /dev/null; then
        echo ".NET SDK is not installed. Installing..."
        sudo pacman -S dotnet-sdk --noconfirm
    fi
}
clone_project() {
    echo "Cloning project from GitHub..."
    git clone https://github.com/AliAgaAbd/Network-tools.git
}
run_dotnet_project() {
    cd Network-tools || exit
    dotnet restore
    dotnet run
}
print_success() {
    echo "Project started successfully!"
}
install_git
install_dotnet
clone_project
run_dotnet_project
print_success
