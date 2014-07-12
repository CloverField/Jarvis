using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    class Time
    {
        public string getCurrentDate()
        {
            DateTime dt = DateTime.Now;
            return dt.ToShortDateString();
        }

        public string getCurrentTime()
        {
            DateTime dt = DateTime.Now;
            return dt.ToShortTimeString();
        }
    }
}