using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrary
{
    /// <summary>
    /// Interface for managing operating system functions like restarting.
    /// </summary>
    interface IOSManagement
    {
        /// <summary>
        /// Restarts the host's operating system.
        /// </summary>
        void Restart();
    }
}
