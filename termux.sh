#!/bin/bash

# بررسی و نصب curl در صورت عدم نصب
if ! command -v curl &> /dev/null; then
    echo "curl نصب نشده است. در حال نصب..."
    sudo pacman -S curl --noconfirm
fi

# بررسی و نصب .NET SDK در صورت عدم نصب
if ! command -v dotnet &> /dev/null; then
    echo ".NET SDK نصب نشده است. در حال نصب..."
    sudo pacman -S dotnet-sdk --noconfirm
fi

# ایجاد پروژه جدید C# اگر پروژه‌ای وجود ندارد
if [ ! -d "my_project" ]; then
    dotnet new console -o my_project --force
fi

# انتقال فایل C# به پروژه
mv Program.cs my_project/

# رفتن به دایرکتوری پروژه
cd my_project || exit

# ساخت و اجرای برنامه C#
dotnet run
