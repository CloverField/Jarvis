using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    class Logic
    {
		public string checkInput(List<string> userInput)
		{
			SystemInfo Si = new SystemInfo();
			Time t = new Time();
			if (userTime (userInput)) 
            {
				return(Si.getUser () + " asked about the time. The time is " + t.getCurrentTime ());
			} 
            else if (userDate (userInput)) 
            {
				return(Si.getUser () + " asked about the date. The date is " + t.getCurrentDate ());
			} 
			else if(userSystem(userInput))
			{
				return(Si.getUser () + " asked about the system. You are currently running " + Si.getOS ());
			}
			else if(userExit(userInput))
			{
				return "0";
			}
            else
            {
				return("Im sorry I dont have a responce for that.");
			}
		}

		private bool userExit(List<string> userInput)
		{
			foreach (string s in userInput) 
			{
				if (s.ToLower ().Equals ("exit")) 
				{
					return true;
				} 
				else 
				{
					return false;
				}
			}
			return false;
		}

		private bool userSystem(List<string> userInput)
		{
			foreach (String s in userInput)
			{
				if (s.ToLower ().Equals ("system")) 
				{
					return true;
				} 
				else 
				{
					return false;
				}
			}
			return false;
		}

		private bool userTime(List<string> userInput)
        {
			foreach (string s in userInput)
            {
                if (s.ToLower().Equals("time"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

		private bool userDate(List<string> userInput)
		{
            foreach (string s in userInput)
            {
                if(s.ToLower().Equals("date"))
                {
					return true;
				}
                else
                {
					return false;
                }
            }
			return false;
    	}
    }
}