using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t = new Time();
            System.Console.WriteLine("Hello my name is Jarvis.");
            System.Console.WriteLine("The current time is " + t.getCurrentTime());
            System.Console.WriteLine("The current date is " + t.getCurrentDate());
            System.Console.ReadLine();
        }
    }
}