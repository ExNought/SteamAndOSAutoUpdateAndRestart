using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrary
{
    /// <summary>
    /// Interface used for all non-SteamCMD processes.
    /// </summary>
    interface ICommonProcess
    {
        /// <summary>
        /// Starts the process.
        /// </summary>
        /// <param name="process">Index of process to be started.</param>
        /// <returns>Returncode, as defined in Returncodes.cs</returns>
        int Start(int process);

        /// <summary>
        /// Stop the process.
        /// </summary>
        /// <param name="process">Index of process to be stoped.</param>
        /// <returns>Returncode, as defined in Returncodes.cs</returns>
        int Stop(int process);

        /// <summary>
        /// Starts all processes in order of their placements in configuration.
        /// </summary>
        /// <returns>Dictionary of returncodes. For each started process there is one entry. 
        /// Key is the processes index, value is the returncode.</returns>
        Dictionary<int,int> StartAll();

        /// <summary>
        /// Stops all processes in order of their placements in configuration, if they are started.
        /// </summary>
        /// <returns>Dictionary of returncodes. For each stoped process there is one entry. 
        /// Key is the processes index, value is the returncode.</returns>
        Dictionary<int,int> StopAll();
    }
}
