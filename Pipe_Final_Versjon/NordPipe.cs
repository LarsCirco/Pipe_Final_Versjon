using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipe_Final_Versjon
{
    internal class NordPipe : IPipe
    {
        public string Symbol => "┃";
        public bool Nord => true;
        public bool Sør => true;
        public bool Vest => false;
        public bool Øst => false;

        public bool sammenkobling()
        {
            return Nord && Sør;
        }

    }

}
