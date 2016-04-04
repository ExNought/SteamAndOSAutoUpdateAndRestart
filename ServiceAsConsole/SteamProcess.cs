namespace ServiceAsConsole
{
    internal class SteamProcess : CommonProcess
    {
        internal new Returncodes.Returncode Start()
        {
            return Returncodes.Returncode.NotResponding;
        }
    }
}