using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sac = Service;

namespace TestApp
{
    /// <summary>
    /// In this app I will add methods to easily test functionality, change something without the need of actually opening the service and so on ;)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Set some basic executables for testing, this also should be default.
            sac.Configuration.ExecutableExtensionsList = new List<string>() { "exe", "msi", "bat", "bin", "cmd", "inf", "vb" };
            foreach(string getExecExtensions in sac.Configuration.ExecutableExtensionsList)
            {
                Console.WriteLine(getExecExtensions);
            }
            Console.ReadLine();
        }
    }
}
