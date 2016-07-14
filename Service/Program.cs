using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This is "deprecated" as all of the entries in here will likely be deleted once my 
/// Dev_SteamCMDService gets to a beta-stage 
/// (which is called feature-complete, in case you only know "betas" as a modern style of demos 
/// with bugs ...)
/// </summary>

namespace Service
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new SteamCMDHandler()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
