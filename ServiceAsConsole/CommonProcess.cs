using System;

namespace ServiceAsConsole
{
    internal class CommonProcess
    {
        private string path;
        private string parameters;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        
        public string Parameters
        {
            get { return parameters; }
            set { parameters = value; }
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