using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
namespace Test1
{
    class Program
    {
        static void Method1()
        {
            for (int i = 0; i < 1000; i++)
            {
                try
                {
                    int value = i * 100;
                    if (value == -1)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                }
            }
        }
        static void Method2()
        {
            try
            {
                for (int i = 0; i < 1000; i++)
                {
                    int value = i * 100;
                    if (value == -1)
                    {
                        throw new Exception();
                    }
                }
            }
            catch
            {
            }
        }
 
        static void Main(string[] args)
        {
 
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Method1();
            sw.Stop();
 
            Console.WriteLine("Within Loop " + sw.ElapsedTicks);
 
            sw.Restart();
            Method2();
            sw.Stop();
            Console.WriteLine("Outside of Loop " + sw.ElapsedTicks);
            Console.ReadLine();
        }
    }
}
