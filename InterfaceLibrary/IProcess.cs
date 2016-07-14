namespace InterfaceLibrary
{
    /// <summary>
    /// Interface for all Processes. Used for SteamCMD and CommonProcesses.
    /// </summary>
    public interface IProcess
    {
        /// <summary>
        /// Path to the executable.
        /// </summary>
        string Path { get; set; }

        /// <summary>
        /// Optional parameters for starting executables.
        /// </summary>
        string Parameters { get; set; }

        /// <summary>
        /// Name as which this process shall be displayed.
        /// </summary>
        string Displayname { get; set; }

        /// <summary>
        /// Number of errors since last clear.
        /// </summary>
        int Errors { get; }

        /// <summary>
        /// Number of starts for this process. Can be cleared.
        /// </summary>
        int Startcount { get; }
    }
}