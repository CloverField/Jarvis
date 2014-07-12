using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    class Logic
    {
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
                    return true
                }
                else
                {
                    return false
                }
            }
            return false
    	}
    }
}