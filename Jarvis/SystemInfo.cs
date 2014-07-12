using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    class SystemInfo
    {
        public string getUser()
        {
            return Environment.UserName;
        }

        public string getOS()
        {
            System.OperatingSystem osInfo = System.Environment.OSVersion;
            return osInfo.ToString();
        }
    }
}