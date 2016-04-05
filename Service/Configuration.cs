using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

//TODO: Reverse public to internal
//TODO: Add validation to make sure there are no dots in front of the extension.
//TODO: Add default values.

namespace Service
{
    public static class Configuration
    {
        /// <summary>
        /// Contains all the fileextensions that are interpretated as executable. This is configurable in the interface and stored in the programms Path.
        /// Extensions get saved with leading dots. E.g. ".exe" instead of "exe".
        /// No extension is always considered Not executable as it is too much of a security issue in my eyes.
        /// </summary>
        public static List<string> ExecutableExtensionsList
        {
            get
            {
                return new List<string>(ConfigurationManager.AppSettings["executableExtensions"].Split(';'));
            }
            //TODO: Make this private again.
            set
            {
                string tmp_newExecListForAppConfig = "";
                foreach (string tmp_execExtension in value)
                {
                    if (!tmp_newExecListForAppConfig.EndsWith(";") && !(tmp_newExecListForAppConfig == String.Empty))
                        tmp_newExecListForAppConfig += ";";

                    if(!tmp_execExtension.StartsWith("."))
                        tmp_newExecListForAppConfig += "." + tmp_execExtension;
                    else
                        tmp_newExecListForAppConfig += tmp_execExtension;
                }
                ConfigurationManager.AppSettings["executableExtensions"] = tmp_newExecListForAppConfig;
            }
        }

    }
}
