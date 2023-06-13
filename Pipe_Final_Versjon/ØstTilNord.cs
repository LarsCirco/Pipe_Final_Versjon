using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipe_Final_Versjon
{
    internal class ØstTilNord : IPipe
    {
        public string Symbol => "╰";
        public bool Nord => true;
        public bool Sør => false;
        public bool Vest => false;
        public bool Øst => true;
        public bool sammenkobling()
        {
            return Nord && Øst;
        }
    }
   
}
