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
            Unknown = 0,
            OK = 1,
            NotResponding = 1053
        }
    }
}
