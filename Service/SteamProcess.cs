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