using System;
using System.Diagnostics;

//TODO: Reverse public to internal
//TODO: Check if wait for 5 seconds causes problems at service shutdown.
//TODO: Add scripted inputs. http://inputsimulator.codeplex.com / http://stackoverflow.com/questions/14064512/simulate-key-stroke-in-any-application

namespace Service
{
    public class CommonProcess
    {
        #region classvariables

        private string path;
        private string parameters;
        private bool doValidatePath;
        private Process process;

        


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
            process.StartInfo.FileName = Path;
            process.StartInfo.Arguments = Parameters;
            try
            {
                process.Start();
                return Returncodes.Returncode.OK;
            }
            catch(InvalidProgramException)
            {
                return Returncodes.Returncode.NotExisting;
            }
            catch(System.ComponentModel.Win32Exception)
            {
                return Returncodes.Returncode.NotExecutable;
            }
            catch
            {
                throw;
            }
        }

        public Returncodes.Returncode Stop()
        {
            //Waits for 5 seconds
            if (process.WaitForExit(5000))
                return Returncodes.Returncode.OK;
            else
                return Returncodes.Returncode.NotResponding;
        }

        public Returncodes.Returncode Stop(bool Force = false)
        {
            if (!Force)
                return Stop();
            //First try the gentle way, but only with 2 seconds wait.
            if (process.WaitForExit(2000))
                return Returncodes.Returncode.OK;
            else
            {
                process.Kill();
                return Returncodes.Returncode.GotKilled;
            }
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