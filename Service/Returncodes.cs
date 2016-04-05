using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: Reverse public to internal

namespace Service
{
    public class Returncodes
    {
        public enum Returncode
        {
            OK = 0,
            Unknown = 666,
            NotExecutable = 5,
            NotExisting = 404,
            NotResponding = 1053
        }
    }
}
