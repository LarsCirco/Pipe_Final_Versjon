using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipe_Final_Versjon
{
    internal interface IPipe

    {
    string Symbol { get; }
    bool Nord { get; }
    bool Sør { get; }

    bool Vest { get; }

    bool Øst { get; }

    bool sammenkobling();

    }
}
