/// <summary>
/// This is "deprecated" as all of the entries in here will likely be deleted once my 
/// Dev_SteamCMDService gets to a beta-stage 
/// (which is called feature-complete, in case you only know "betas" as a modern style of demos 
/// with bugs ...)
/// </summary>


//TODO: Reverse public to internal

namespace Service
{
    public class SteamProcess : CommonProcess
    {
        public new Returncodes.Returncode Start()
        {
            return Returncodes.Returncode.NotResponding;
        }
    }
}