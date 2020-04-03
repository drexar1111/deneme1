using System;
using System.IO;
using System.Diagnostics;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessStartInfo ps = new ProcessStartInfo();

            ps.Arguments = "-p -100 192.168.1.39";//processler
            ps.RedirectStandardOutput = true;

            ps.FileName = "nmap";//programın ismi
            Process p = new Process();
            p.StartInfo = ps;
            p.Start();

            StreamReader ayhan = p.StandardOutput;
            StreamWriter sw = new StreamWriter("ayhan.txt");
            sw.WriteLine(ayhan.ReadToEnd());

            p.WaitForExit();

            Console.WriteLine("Program Bitmiştir.");

            Console.ReadKey(true);
        }
    }
}
