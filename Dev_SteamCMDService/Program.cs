using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Pipes;

/// <summary>
/// In here I develop the service, that later on will power up  and down the steamcmd and manage 
/// the SCMD-servers.
/// 
/// So to be clear: This is a temporary project to ease up development of services. Until the main
/// stuff is done and I have a working state, I will refactor this to the service. 
/// This should then be of no big problem. I will programm this from start as if this were a 
/// service.
/// </summary>
namespace Dev_SteamCMDService
{
    class Program
    {
        static void Main(string[] args)
        {
            AnonymousPipeServerStream(PipeDirection.)
            var test = new NamedPipeServerStream("Test");

            test.BeginWrite()
        }
    }
}
