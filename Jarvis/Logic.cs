using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    class Logic
    {
        public string userTime(List<string> question)
        {
            foreach (string s in question)
            {
                if (s.Equals("Time")||s.Equals("time"))
                {
                    Time t = new Time();
                    return t.getCurrentTime();
                }
                else
                {
                    return "";
                }
            }
            return "";
        }
    }
}
