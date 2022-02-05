using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieAgentie
{ [Flags]
    public enum Gradfinisare
    {
        Rosu = 1,
        Gri = 2,
        Alb = 3,
        Cheie = 4

    };
    [Flags]
    public enum CompartimentareA
    {
        Decomodat = 1,
        Semidecomodat = 2,
        Nedecomodat = 3,
        Circular = 4

    };
}
