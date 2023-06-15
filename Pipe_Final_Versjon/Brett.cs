using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pipe_Final_Versjon
{
    internal class Brett
    {
        private Random random = new Random();
        public List<IPipe> Pipes { get; set; } = new List<IPipe>();
        private int start = 0;
        private int end;

        public Brett()
        {
            RenderBoard();
            DrawBoard();
        }

        public void RenderBoard()
        {
            for (var i = 0; i < 100; i++)
            {
                Pipes.Add(RandomPipe());
            }
        }

        public void DrawBoard()
        {
            int count = 0;
            string padding = new string(' ', 2);
            foreach (var pipe in Pipes)
            {
                Console.Write(padding+pipe.Symbol + " ");
                count++;
                if (count % 10 == 0)
                {Console.WriteLine(" ");}
            }
        }
        private IPipe RandomPipe()
        {
            int tilfeldig = random.Next(2);
            switch (tilfeldig)
            {
                case 0:
                    return new NordPipe();
              
                case 1:
                    return new ØstTilNord();
                default: throw new InvalidOperationException("invalid");
            }
        }

        public void userInput (string input, string direction)
        {
            int.TryParse(input, out int index);
            Pipes[index] = new NordPipe();
            DrawBoard();
        }

        public bool Kobling()
        {
            for (int i = 0; i < Pipes.Count; i++)
            {
                int nord = i - 10;
                int sør = i + 10;
                int øst = i + 1;
                int vest = i - 1;
                bool nord = false, sør = false, vest = false, øst = false;

                if (nord >= 0 && !Pipes[i].sammenkobling(Pipes[nord]))
                    return false;
                if (sør < Pipes.Count && !Pipes[i].sammenkobling(Pipes[sør]))
                    return false;
                if (vest >= 0 && i % 10 != 0 && !Pipes[i].sammenkobling(Pipes[vest])) 
                    return false;
                if (øst < Pipes.Count && (i + 1) % 10 != 0 && !Pipes[i].sammenkobling(Pipes[øst])) 
                    return false;
            }
            return true; 
        }
        
    }
}