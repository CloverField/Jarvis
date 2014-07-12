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
            SystemInfo si = new SystemInfo();
            Logic l = new Logic();
            List<string> responce = new List<string>();
            System.Console.WriteLine("Hello my name is Jarvis.");
            System.Console.WriteLine("The current time is " + t.getCurrentTime() + ".");
            System.Console.WriteLine("The current date is " + t.getCurrentDate() + ".");
            System.Console.WriteLine("The currrent user is " + si.getUser() + ".");
            System.Console.WriteLine("The current OS version is " + si.getOS() + ".");
            System.Console.WriteLine("Would you like know about the time? If you do please respond time.");
            responce.Add(Console.ReadLine());
            if (l.userTime(responce))
            {
                System.Console.WriteLine("The user asked about the time. The time is " + t.getCurrentTime() + ".");
            }
            System.Console.ReadLine();
        }
    }
}