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
			System.Console.WriteLine ("What would you like to know?");
			while (true) 
			{
				responce.Add (Console.ReadLine ());
				if (l.checkInput (responce).Equals ("0")) {
					System.Console.WriteLine ("See you later");
					Environment.Exit (0);
				}
				else{
					System.Console.WriteLine (l.checkInput (responce));
				}
				responce.Clear();
			}
            System.Console.ReadLine();
        }
    }
}