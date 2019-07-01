using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestingFrameworkAppDocker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Starting");

            Thread.Sleep(10000);

            Console.WriteLine("Continuing Program Execution");

            Thread.Sleep(10000);

            Console.WriteLine("Closing Program!");
        }
    }
}
