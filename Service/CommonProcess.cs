using System;

//TODO: Reverse public to internal

namespace Service
{
    public class CommonProcess
    {
        #region classvariables

        private string path;
        private string parameters;
        private bool doValidatePath;

        #endregion classvariables

        #region properties
        
        /// <summary>
        /// This contains the path to the executable.
        /// If ValidatePath is true the Property checks if the 
        /// </summary>
        public string Path
        {
            get { return path; }
            set
            {
                if (DoValidatePath)
                    ValidatePath(value);
                else
                    path = value;
            }
        }
        
        /// <summary>
        /// This contains parameters which are passed to the executed process. Those have to be checked by the user, validation is not possible?
        /// </summary>
        public string Parameters
        {
            get { return parameters; }
            set { parameters = value; }
        }

        /// <summary>
        /// If this is enabled the path will be checked for an executable at destination. Executables are defined in config.
        /// </summary>
        public bool DoValidatePath
        {
            get { return doValidatePath; }
            set { doValidatePath = value; }
        }

        #endregion properties

        public Returncodes.Returncode Start()
        {
            return Returncodes.Returncode.NotResponding;
        }

        public Returncodes.Returncode Stop()
        {
            return Returncodes.Returncode.NotResponding;
        }

        public Returncodes.Returncode Stop(bool Force = false)
        {
            if (!Force)
                return Stop();
            return Returncodes.Returncode.NotResponding;
        }


        private Returncodes.Returncode ValidatePath(string value)
        {
            string extension = "";
            if (System.IO.File.Exists(value))
            {
                extension = System.IO.Path.GetExtension(value);
                if (extension == "")
                    return Returncodes.Returncode.NotExecutable;
                foreach (string execExtension in Configuration.ExecutableExtensionsList)
                {
                    if (extension == execExtension)
                        return Returncodes.Returncode.OK;
                }
                return Returncodes.Returncode.NotExecutable;
            }
            return Returncodes.Returncode.NotExisting;
        }
    }
}