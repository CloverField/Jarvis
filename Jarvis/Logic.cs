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
				return(Si.getUser () + " asked about the time the time is " + t.getCurrentTime ());
			} 
            else if (userDate (userInput)) 
            {
				return(Si.getUser () + " asked about the date the date is " + t.getCurrentDate ());
			} 
            else 
            {
				return("The user did not ask about the time or the date.");
			}
		}

		public bool userTime(List<string> userInput)
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

		public bool userDate(List<string> userInput)
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