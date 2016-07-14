using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This is "deprecated" as all of the entries in here will likely be deleted once my 
/// Dev_SteamCMDService gets to a beta-stage 
/// (which is called feature-complete, in case you only know "betas" as a modern style of demos 
/// with bugs ...)
/// </summary>


//TODO: Reverse public to internal

namespace Service
{
    public class ProcessHandling
    {
        private Dictionary<string,SteamProcess> lst_SteamProcesses;
        private Dictionary<string,CommonProcess> lst_CommonProcesses;

        public Dictionary<string, SteamProcess> SteamProcesses
        {
            get { return lst_SteamProcesses; }
            set { lst_SteamProcesses = value; }
        }
        
        public Dictionary<string, CommonProcess> CommonProcesses
        {
            get { return lst_CommonProcesses; }
            set { lst_CommonProcesses = value; }
        }
        
        public Returncodes.Returncode startAllProcesses()
        {
            foreach(KeyValuePair<string, SteamProcess> kvp_stringSteamProcess in lst_SteamProcesses)
            {
                SteamProcess tmp_SteamProcess = kvp_stringSteamProcess.Value;

                tmp_SteamProcess.Start();
            }

            foreach (KeyValuePair<string, CommonProcess> kvp_stringCommonProcess in lst_CommonProcesses)
            {
                CommonProcess tmp_CommonProcess = kvp_stringCommonProcess.Value;

                tmp_CommonProcess.Start();
            }

            return Returncodes.Returncode.NotResponding;
        }


    }
}
