﻿using Microsoft.CSharp;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Net.NetworkInformation;
using System.Diagnostics;
using static System.Net.WebRequestMethods;
using System.IO;
using File = System.IO.File;
using System.Runtime.InteropServices;
namespace main
{
    class Program
    {
        public static void Main()
        {
            string path = "0";
            string path2 = "0";
            string path3 = "0";
            string path4 = "0";
            string path5 = "0";
            string path6 = "0";
            string path7 = "0";
            string path8 = "0";
            if (OperatingSystem.IsWindows() == true)
            {
                path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\All ping.csv";
                path2 = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\High ping.csv";
                path3 = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Uptime.csv";
                path4 = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Uptime error list.csv";
                path5 = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\uptime target.csv";
                path6 = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\uptime target error.csv";
                path7 = $"{AppDomain.CurrentDomain.BaseDirectory}\\speedtest";
                path8 = $"{AppDomain.CurrentDomain.BaseDirectory}\\speedtest\\speedtest.exe";
            }
            if (OperatingSystem.IsLinux() == true)
            {
                path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/All ping.csv";
                path2 = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/High ping.csv";
                path3 = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/Uptime.csv";
                path4 = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/Uptime error list.csv";
                path5 = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/uptime target.csv";
                path6 = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/uptime target error.csv";
                path7 = $"{AppDomain.CurrentDomain.BaseDirectory}/speedtest";
                path8 = $"{AppDomain.CurrentDomain.BaseDirectory}/speedtest/speedtest";
            }
            if (OperatingSystem.IsMacOS() == true)
            {
                path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\All ping.csv";
                path2 = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\High ping.csv";
                path3 = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Uptime.csv";
                path4 = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Uptime error list.csv";
                path5 = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\uptime target.csv";
                path6 = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\uptime target error.csv";
                path7 = $"{AppDomain.CurrentDomain.BaseDirectory}\\speedtest";
                path8 = $"{AppDomain.CurrentDomain.BaseDirectory}\\speedtest\\speedtest";
            }
            Console.WriteLine("\n\tHello! welcome to network tools.\n");
            Console.Write("\n\tPlease select your theme (light, dark, default is dark yellow): ");
            theme(Console.ReadLine());
            Console.Clear();
            while (true)
            {
                Console.Clear();
                Console.Write("\n\t|Please enter your tool|\n\t°Ping measure = ping°\n\t°Server up time = time°\n\t°Network status = status°\n\t°Speed test = speed°\n\t°Re-select theme = theme°\n\t°Help = help°\n\t°Exit = exit°\n\t▒Enter your choice: ");
                string select = Console.ReadLine();
                switch (select)
                {
                    case "ping":
                    case "Ping":
                    case "PING":
                        {
                            try
                            {
                                File.Delete(path);
                                File.Delete(path2);
                            }
                            catch { Console.Clear(); Console.WriteLine("\n\tFiles All ping.csv or High ping.csv are in use by another program, please close them and re-run the program"); Console.Write("\n\tPress any key to return to home: "); Console.ReadKey(); break; }
                            var ping = new Ping();
                            string number, wait, host;
                            int counter = 1; int counter2 = 1; int errorCounter = 0; int wait2 = 0; int number2 = 0; int error; int timeoutCounter = 0; int loop = 0; int sign = 0; int sign2 = 0; int sign3 = 0;
                            Console.Clear();
                            while (true)
                            {
                                try
                                {
                                    Console.Write("\n\tEnter your host, enter 1 to return to main menu: ");
                                    host = Console.ReadLine();
                                    if (host == "1") break;
                                    ping.Send(host);
                                    break;
                                }
                                catch { Console.WriteLine("\n\tInvalid host, please enter a valid host"); continue; }
                            }
                            if (host == "1") break;
                            while (true)
                            {
                                try
                                {
                                    Console.Write("\n\tEnter number of pings, enter 1 to return to main menu, enter 0 to ping until you press end key: ");
                                    number = Console.ReadLine();
                                    if (number == "1") break;
                                    if (number == "0") break;
                                    number2 = Convert.ToInt32(int.Parse(number));
                                    sign = Math.Sign(number2);
                                    if (sign == -1) throw new ArgumentException("");
                                    break;
                                }
                                catch { if (sign == -1) { Console.WriteLine("\n\tPlease don't enter minus number, this amount can be only 0 or >0"); continue; } Console.WriteLine("\n\tInvalid input, please enter valid input"); continue; }
                            }
                            if (number == "1") break;
                            while (true)
                            {
                                try
                                {
                                    Console.Write("\n\tEnter your ping interval in milli seconds, enter -1 to return to main menu: ");
                                    wait = Console.ReadLine();
                                    if (wait == "-1") break;
                                    wait2 = Convert.ToInt32(int.Parse(wait));
                                    sign2 = Math.Sign(wait2);
                                    if (sign2 == -1) throw new ArgumentException("\n\tPlease don't enter minus number, this amount can be only 0 or >0");
                                    break;
                                }
                                catch { if (sign2 == -1) { Console.WriteLine("\n\tPlease don't enter minus number, this amount can be only 0 or >0"); continue; } Console.WriteLine("\n\tInvalid input, please enter valid input"); continue; }
                            }
                            if (wait == "-1") break;
                            while (true)
                            {
                                try
                                {
                                    Console.Write("\n\tEnter your high ping alert, enter -1 to return to main menu: ");
                                    error = Convert.ToInt32(int.Parse(Console.ReadLine()));
                                    sign3 = Math.Sign(error);
                                    if (sign3 == -1) throw new ArgumentException("\n\tPlease don't enter minus number, this amount can be only 0 or >0");
                                    if (error == -1) break;
                                    break;
                                }
                                catch { if (sign3 == -1) { Console.WriteLine("\n\tPlease don't enter minus number, this amount can be only 0 or >0"); continue; } Console.WriteLine("\n\tInvalid input, please enter valid input"); continue; }
                            }
                            if (error == -1) break;
                            if (number == "0")
                            {
                                while (true)
                                {
                                    var data = DateTime.Now;
                                    var ping2 = new Ping().Send(host);
                                    Console.WriteLine($"\nNumber = {counter}   status = {ping2.Status}   address = {ping2.Address}   duration = {ping2.RoundtripTime}ms   packet size = {ping2.Buffer.Length}   hash = {ping2.GetHashCode()}");
                                    File.AppendAllText(path, $"Number = {counter}   status = {ping2.Status}   address = {ping2.Address}   duration = {ping2.RoundtripTime}ms   time = {data.ToString("yyyy, MM, dd HH:mm:ss")}   packet size = {ping2.Buffer.Length}   hash = {ping2.GetHashCode()}\n");
                                    if (ping2.RoundtripTime > error)
                                    {
                                        errorCounter++;
                                        File.AppendAllText(path2, $"Ping {counter} had an high ping    status = {ping2.Status}    address = {ping2.Address}    duration = {ping2.RoundtripTime}   time = {data.ToString("yyyy, MM, dd HH:mm:ss")}   packet size = {ping2.Buffer.Length}   hash = {ping2.GetHashCode()}\n");
                                    }
                                    if (ping2.Status == IPStatus.TimedOut)
                                    {
                                        timeoutCounter++;
                                        File.AppendAllText(path2, $"Ping {counter} Timed out    status = {ping2.Status}    address = {ping2.Address}    duration = {ping2.RoundtripTime}   time = {data.ToString("yyyy, MM, dd HH:mm:ss")}   packet size = {ping2.Buffer.Length}   hash = {ping2.GetHashCode()}\n");
                                    }
                                    Thread.Sleep(wait2);
                                    if (Console.KeyAvailable)
                                    {
                                        var key = Console.ReadKey(intercept: true).Key;
                                        if (key == ConsoleKey.End) { loop = 1000; break; }
                                    }
                                    counter2++;
                                    counter++;
                                }
                                File.AppendAllText(path2, $"All packets = {counter2}    High pings = {errorCounter}    High ping percent = {(float)((float)((float)errorCounter / (float)counter2) * 100)}%    Packet loss = {timeoutCounter}    Packet loss percent = {(float)((float)((float)timeoutCounter / (float)counter2) * 100)}%\n");
                                Console.WriteLine("\n\tOperation was successful, please refer to All ping.csv and High ping.csv created in Desktop for more details");
                                Console.Write("\nPress any key to return to home: ");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            if (loop == 1000) break;
                            while (counter < number2 + 1)
                            {
                                var data = DateTime.Now;
                                var ping2 = new Ping().Send(host);
                                Console.WriteLine($"\nNumber = {counter}   status = {ping2.Status}   address = {ping2.Address}   duration = {ping2.RoundtripTime}ms   packet size = {ping2.Buffer.Length}   hash = {ping2.GetHashCode()}");
                                File.AppendAllText(path, $"Number = {counter}   status = {ping2.Status}   address = {ping2.Address}   duration = {ping2.RoundtripTime}ms   time = {data.ToString("yyyy, MM, dd HH:mm:ss")}   packet size = {ping2.Buffer.Length}   hash = {ping2.GetHashCode()}\n");
                                if (ping2.RoundtripTime > error)
                                {
                                    errorCounter++;
                                    File.AppendAllText(path2, $"Ping {counter} had an high ping    status = {ping2.Status}    address = {ping2.Address}    duration = {ping2.RoundtripTime}   time = {data.ToString("yyyy, MM, dd HH:mm:ss")}   packet size = {ping2.Buffer.Length}   hash = {ping2.GetHashCode()}\n");
                                }
                                if (ping2.Status == IPStatus.TimedOut)
                                {
                                    timeoutCounter++;
                                    File.AppendAllText(path2, $"Ping {counter} Timed out    status = {ping2.Status}    address = {ping2.Address}    duration = {ping2.RoundtripTime}   time = {data.ToString("yyyy, MM, dd HH:mm:ss")}   packet size = {ping2.Buffer.Length}   hash = {ping2.GetHashCode()}\n");
                                }
                                Thread.Sleep(wait2);
                                counter++;
                            }
                            File.AppendAllText(path2, $"All packets = {number2}    High pings = {errorCounter}    High ping percent = {(float)((float)((float)errorCounter / (float)number2) * 100)}%    Packet loss = {timeoutCounter}    Packet loss percent = {(float) ((float)((float)timeoutCounter / (float)number2) * 100)}%\n");
                            Console.WriteLine("\n\tOperation was successful, please refer to All ping.csv and High ping.csv created in Desktop for more details");
                            Console.Write("\nPress any key to return to home: ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "time":
                    case "TIME":
                    case "Time":
                        {
                            Console.Clear();
                            double uptime = 0; long uptimeCounter = 0; long uptimeCounter2 = 0;
                            List<long> pings = new List<long>();
                            Console.Write("\n\tIs this your server runnig program in (y/n): ");
                            string server = Console.ReadLine();
                            switch (server)
                            {
                                case "y":
                                case "Y":
                                    {
                                        try
                                        {
                                            File.Delete(path3);
                                            File.Delete(path4);
                                        }
                                        catch { Console.WriteLine("\n\tThe file Uptime.csv or Uptime error list.csv using by another program, please close the program and re-run the program"); Console.Write("Press any key to return to home: "); Console.ReadKey(); break; }
                                        while (true)
                                        {
                                            try
                                            {
                                                Console.Write("\n\tPlease enter your time interval you want to test (hours), enter -1 to return to home: ");
                                                uptime = Convert.ToDouble(double.Parse(Console.ReadLine()));
                                                if (uptime == -1) break;
                                                if (Math.Sign(uptime) == -1 || uptime == 0) throw new ArgumentException("");
                                                break;
                                            }
                                            catch { if (Math.Sign(uptime) == -1 || uptime == 0) { Console.WriteLine("\n\tPlease don't enter minus number or 0!, entry should be >0"); continue; } Console.WriteLine("\n\tPlease enter a valid input"); continue; }
                                        }
                                        if (uptime == -1) break;
                                        Stopwatch exitloop = Stopwatch.StartNew();
                                        while (true)
                                        {
                                            var time2 = DateTime.Now;
                                            if (uptime * 60 * 60 * 1000 < exitloop.ElapsedMilliseconds) break;
                                            var ping = new Ping().Send("8.8.8.8");
                                            pings.Add(ping.RoundtripTime);
                                            if (ping.Status == IPStatus.TimedOut)
                                            {
                                                File.AppendAllText(path4, $"Packet failer time = {time2.ToString("yyyy, MM, dd HH:mm:ss:f")}\n");
                                                uptimeCounter2++;
                                            }
                                            if (uptimeCounter == 9223372036854775806)
                                            {
                                                Console.WriteLine("\n\tThe limit of program riched, so you should close and re-run the program\n\tResults are saved in Uptime.csv and Uptime error list.csv");
                                                break;
                                            }
                                            uptimeCounter++;
                                            Thread.Sleep(100);
                                        }
                                        File.AppendAllText(path3, $"Uptime = {(float)((float)((float)(uptimeCounter - uptimeCounter2) / uptimeCounter) * 100)}%    All pings = {uptimeCounter}    Successful pings = {uptimeCounter - uptimeCounter2}    failer pings = {uptimeCounter2}    failer pings percentage = {(float)(uptimeCounter2 / uptimeCounter) * 100}%    average ping = {(float)pings.Average()}ms    host = {"8.8.8.8"}\n");
                                        if (uptimeCounter2 == 0) {File.AppendAllText(path4, "Congratulations! your server don't have any errors");}
                                        Console.WriteLine("\n\tOperation was successful, Please refer to files Uptime.csv and Uptime error list.csv for more details\n");
                                        Console.Write("\nPress any key to return to home: ");
                                        Console.ReadKey();
                                        break;
                                    }
                                case "n":
                                case "N":
                                {
                                    Console.Clear();
                                    try
                                    {
                                        File.Delete(path5);
                                        File.Delete(path6);
                                    } catch {Console.WriteLine("\n\tFiles uptime target.csv or uptime target error.csv are in use by another program, please close them and re-run the program"); Console.WriteLine("\nPress any key to reurn to home: "); Console.ReadKey(); break; }
                                    string hostuptime;
                                    double hoursuptime = 0;
                                    long targeterrorcounter = 0;
                                    long targetcounter = 0;
                                    List<long> targetpings = new List<long>();
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.Write("\n\tPlease enter your hosts ip address or sni, enter 1 to return to home: ");
                                            hostuptime = Console.ReadLine();
                                            if (hostuptime == "1") break;
                                            var pinguptime = new Ping().Send(hostuptime);
                                            break;
                                        } catch {Console.WriteLine("\n\tInvalid input, please enter valid input"); continue; }    
                                    }
                                    if (hostuptime == "1") break;
                                    while (true)
                                    {
                                        try
                                        {
                                        Console.Write("\n\tEnter your time interval you want to check the up time (hours), enter -1 to return to home: ");
                                        hoursuptime = Convert.ToDouble(double.Parse(Console.ReadLine()));
                                        if (hoursuptime == -1) break;
                                        if (Math.Sign(hoursuptime) == -1 || hoursuptime == 0) throw new ArgumentException("");
                                        break;
                                        } catch { if (Math.Sign(hoursuptime) == -1 || hoursuptime == 0) {Console.WriteLine("\n\tPlease don't enter minus number or 0!, entry should be >0"); continue; } Console.WriteLine("\n\tInvalid input, please enter a valid input"); continue; }
                                    }
                                    if (hoursuptime == -1) break;
                                    Stopwatch exituptime = Stopwatch.StartNew();
                                    while (true)
                                    {
                                        if (hoursuptime * 60 * 60 * 1000 < exituptime.ElapsedMilliseconds) break;
                                        var pinguptimetarget = new Ping().Send(hostuptime);
                                        var datawrite = DateTime.Now;
                                        targetpings.Add(pinguptimetarget.RoundtripTime);
                                        if (pinguptimetarget.Status == IPStatus.TimedOut)
                                        {
                                            File.AppendAllText(path6, $"Packet failer time = {datawrite.ToString("yyyy, MM, dd HH:mm:ss:f")}\n");
                                            targeterrorcounter++;
                                        }
                                        if (targetcounter == 9223372036854775806)
                                        {
                                            Console.WriteLine("\n\tThe limit of program riched, so you should close and re-run the program\n\tResults are saved in Uptime.csv and Uptime error list.csv");
                                            break;
                                        }
                                        targetcounter++;
                                        Thread.Sleep(100);
                                    }
                                    File.AppendAllText(path5, $"Uptime = {(float)((float)(targetcounter - targeterrorcounter) / targetcounter) * 100}    All pings = {targetcounter}    Failer packets = {targeterrorcounter}    Failer packets percentage = {(float)(targeterrorcounter / targetcounter) * 100}%    Average ping = {(float)targetpings.Average()}ms    Host = {(string)hostuptime}");
                                    if (targeterrorcounter == 0) {File.AppendAllText(path6, "Congratulations! your server don't have any errors");}
                                    Console.WriteLine("\n\tOperation was successful, please refer to files Uptime target.csv and Uptime target error.csv created in desktop for more details\n");
                                    Console.Write("\nPress any ket to return to home: ");
                                    Console.ReadKey();
                                    break;
                                }
                                case null:
                                {
                                    Console.Clear();
                                    break;
                                }
                                default:
                                {
                                    Console.Clear();
                                    break;
                                }
                            }
                            break;
                        }
                    case "speed":
                    case "Speed":
                    case "SPEED":
                        {
                            Process process = new Process();
                            process.StartInfo.FileName = $"{path8}";
                            Console.Clear();
                            Console.Write("\n\tPress any key to start speed test, it might use about 100~150MB data\n");
                            Console.ReadKey();
                            if (OperatingSystem.IsLinux() == true)
                            {
                                try
                                {
                                        Console.WriteLine("\n\tGetting permission...");
                                        string command = $"chmod +x {path8}";
                                        Process access = new Process();
                                        access.StartInfo.FileName = "/bin/bash";
                                        access.StartInfo.Arguments = $"-c \"{command}\"";
                                        access.StartInfo.RedirectStandardOutput = true;
                                        access.StartInfo.RedirectStandardError = false;
                                        access.StartInfo.UseShellExecute = false;
                                        access.StartInfo.CreateNoWindow = true;
                                        access.Start();
                                        string output = access.StandardOutput.ReadToEnd();
                                        access.WaitForExit();
                                        Console.WriteLine($"\n\t{output}");
                                        process.Start();
                                        process.WaitForExit();
                                        Console.WriteLine("Press Ctrl+mouse left click to open following link\n");
                                }
                                catch
                                {
                                    if (Directory.Exists($"{path7}") == true)
                                    {
                                        File.Delete($"{path8}");
                                        Directory.Delete($"{path7}");
                                    }
                                    Directory.CreateDirectory($"{path7}");
                                    speed();
                                }
                            }
                            else if (OperatingSystem.IsWindows() == true || OperatingSystem.IsMacOS() == true)
                            {
                                try
                                {
                                    process.Start();
                                    process.WaitForExit();
                                }
                                catch
                                {
                                    if (Directory.Exists($"{path7}") == true)
                                    {
                                        File.Delete($"{path8}");
                                        Directory.Delete($"{path7}");
                                    }
                                    Directory.CreateDirectory($"{path7}");
                                    speed();
                                }
                            }
                            Console.Write("\nPress any key to return to home: ");
                            Console.ReadKey();
                            break;
                        }
                }
                if (select == "exit" || select == "Exit" || select == "EXIT") break;
            }
            Console.ReadKey();
        }
        public static void theme(string theme)
        {
            switch (theme)
            {
                case "light":
                case "Light":
                case "LIGHT":
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        break;
                    }
                case "dark":
                case "Dark":
                case "DARK":
                    {
                        Console.ResetColor();
                        Console.Clear();
                        break;
                    }
                case null:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        break;
                    }
                default:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        break;
                    }
            }
        }
        public static void speed()
        {
            WebClient downloadFile = new WebClient();
            string path = "0";
            if (OperatingSystem.IsWindows() == true)
            {
                path = $"{AppDomain.CurrentDomain.BaseDirectory}\\speedtest\\speedtest.exe";
            }
            if (OperatingSystem.IsLinux() == true)
            {
                path = $"{AppDomain.CurrentDomain.BaseDirectory}/speedtest/speedtest";
            }
            if (OperatingSystem.IsMacOS() == true)
            {
                path = $"{AppDomain.CurrentDomain.BaseDirectory}\\speedtest\\speedtest";
            }
            if (OperatingSystem.IsLinux() == true)
            {
                string architecture = RuntimeInformation.OSArchitecture.ToString();
                Console.WriteLine("\n\tSpeedtest file not found, Downloading file...please wait");
                try
                {
                    Console.WriteLine("\n\tDetecting processor architecture...");
                    Console.WriteLine($"\n\tArchitecture : {architecture}");
                    if (architecture == "X64")
                    {
                        downloadFile.DownloadFile("https://raw.githubusercontent.com/AliAgaAbd/Network-tools/refs/heads/main/Speedtest%20client%20(API)/Linux-x64/speedtest", $"{path}");
                    }
                    if (architecture == "X86")
                    {
                        downloadFile.DownloadFile("https://raw.githubusercontent.com/AliAgaAbd/Network-tools/refs/heads/main/Speedtest%20client%20(API)/Linux-x86/speedtest", $"{path}");
                    }
                    if (architecture == "arm64")
                    {
                        downloadFile.DownloadFile("https://raw.githubusercontent.com/AliAgaAbd/Network-tools/refs/heads/main/Speedtest%20client%20(API)/Linux-arm64(ARMv8)/speedtest", $"{path}");
                    }
                    if (architecture == "arm")
                    {
                        downloadFile.DownloadFile("https://raw.githubusercontent.com/AliAgaAbd/Network-tools/refs/heads/main/Speedtest%20client%20(API)/Linux-arm32(ARMv7)/speedtest", $"{path}");
                    }
                    Console.WriteLine("\n\tDownloaded file successfully, getting permission...");
                    string command = $"chmod +x {path}";
                    Process access = new Process();
                    access.StartInfo.FileName = "/bin/bash";
                    access.StartInfo.Arguments = $"-c \"{command}\"";
                    access.StartInfo.RedirectStandardOutput = true;
                    access.StartInfo.RedirectStandardError = false;
                    access.StartInfo.UseShellExecute = false;
                    access.StartInfo.CreateNoWindow = true;
                    access.Start();
                    string output = access.StandardOutput.ReadToEnd();
                    access.WaitForExit();
                    Console.WriteLine(output);
                    Process process = new Process();
                    process.StartInfo.FileName = $"{path}";
                    process.Start();
                    process.WaitForExit();
                    Console.WriteLine("Press Ctrl+mouse left click to open following link\n");
                }
                catch { Console.WriteLine("\n\tNetwork error, please check your internrt connection and re-run program\n"); }
            }
            if (OperatingSystem.IsWindows() == true)
            {
                Console.WriteLine("\n\tSpeedtest file not found, Downloading file...please wait");
                try
                {
                    downloadFile.DownloadFile("https://raw.githubusercontent.com/AliAgaAbd/Network-tools/refs/heads/main/Speedtest%20client%20(API)/Windows-x64/speedtest.exe", $"{path}");
                    Console.WriteLine("\n\tDownloaded file successfully, running speedtest...");
                    Process process = new Process();
                    process.StartInfo.FileName = $"{path}";
                    process.Start();
                    process.WaitForExit();
                    Console.WriteLine("Press Ctrl+mouse left click to open following link\n");
                }
                catch { Console.WriteLine("\n\tNetwork error, please check your internrt connection and re-run program\n"); }
            }
            if (OperatingSystem.IsMacOS() == true)
            {
                Console.WriteLine("\n\tSpeedtest file not found, Downloading file...please wait");
                try
                {
                    downloadFile.DownloadFile("https://raw.githubusercontent.com/AliAgaAbd/Network-tools/refs/heads/main/Speedtest%20client%20(API)/MacOS-universal/speedtest", $"{path}");
                    Console.WriteLine("\n\tDownloaded file successfully, running speedtest...");
                    Process process = new Process();
                    process.StartInfo.FileName = $"{path}";
                    process.Start();
                    process.WaitForExit();
                    Console.WriteLine("Press Ctrl+mouse left click to open following link\n");
                }
                catch { Console.WriteLine("\n\tNetwork error, please check your internrt connection and re-run program\n"); }
            }
        }
    }
}