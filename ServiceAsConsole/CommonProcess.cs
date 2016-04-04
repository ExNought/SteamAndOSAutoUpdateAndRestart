using System;

namespace ServiceAsConsole
{
    internal class CommonProcess
    {
        private string path;
        private string parameters;
        private bool validatePath;

        /// <summary>
        /// This contains the path to the executable.
        /// If ValidatePath is true the Property checks if the 
        /// </summary>
        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Parameters
        {
            get { return parameters; }
            set { parameters = value; }
        }

        public bool ValidatePath
        {
            get { return validatePath; }
            set { validatePath = value; }
        }
        
        internal Returncodes.Returncode Start()
        {
            return Returncodes.Returncode.NotResponding;
        }

        internal Returncodes.Returncode Stop()
        {
            return Returncodes.Returncode.NotResponding;
        }

        internal Returncodes.Returncode Stop(bool Force = false)
        {
            if (!Force)
                Stop();
        }

    }
}