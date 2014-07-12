using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    class Logic
    {
        public bool userTime(List<string> question)
        {
            foreach (string s in question)
            {
                if (s.ToLower().Equals("time"))
                {
                    Time t = new Time();
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
