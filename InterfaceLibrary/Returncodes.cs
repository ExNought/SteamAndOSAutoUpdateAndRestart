using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesLibrary
{
    /// <summary>
    /// Returncodes.Returncode defines every returncode used in the whole solution. 
    /// The name is usually choosen to be self-explanatory.
    /// </summary>
    public static class Returncodes
    {
        /// <summary>
        /// Enum of every code used in the whole solution. Codes are in range of int32.
        /// </summary>
        public enum Returncode
        {
            /// <summary>
            /// Everything went good.
            /// </summary>
            OK = 0,
            /// <summary>
            /// A task got canceled and stoped.
            /// </summary>
            Canceled = 1,
            /// <summary>
            /// Something weird happened, with unknown cause. This should be an rare error.
            /// In most cases the Log should be able to help.
            /// </summary>
            Unknown = 666,
            /// <summary>
            /// The referenced file is not an executable.
            /// </summary>
            NotExecutable = 5,
            /// <summary>
            /// The referenced file is not exisiting.
            /// </summary>
            NotExisting = 404,
            /// <summary>
            /// A response took too long.
            /// </summary>
            NotResponding = 1053,
            /// <summary>
            /// A task got forcefully terminated. This is needed, if for example a pending cancel
            /// failed to be executed.
            /// </summary>
            GotKilled = 111
        }
    }
}
