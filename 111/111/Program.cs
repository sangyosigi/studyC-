using System;
using static System.Console;
namespace _111
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("ex: HelloApp.exe<이름>");
                return;
            }
            Console.WriteLine($"Hello,{args[0]}");
        }
    }
}
