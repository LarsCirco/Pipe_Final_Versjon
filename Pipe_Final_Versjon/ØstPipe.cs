using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipe_Final_Versjon
{
    internal class ØstPipe 
    {
        public string Symbol => "━";
        public bool Nord => false;
        public bool Sør => false;
        public bool Vest => true;
        public bool Øst => true;

        public bool sammenkobling()
        {
            return Vest && Øst;
        }
    }
}
