using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    class RandomNumGen
    {
        private string generateRandomNum(string lower, string upper)
        {
            Random rand = new Random();
            return rand.Next(Convert.ToInt32(lower), Convert.ToInt32(upper)).ToString();
        }
    }
}
