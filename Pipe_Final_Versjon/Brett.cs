using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pipe_Final_Versjon
{
    internal class Brett
    {
        private Random random = new Random();
        public List<IPipe> Pipes { get; set; } = new List<IPipe>();

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
            int tilfeldig = random.Next(3);
            switch (tilfeldig)
            {
                case 0:
                    return new NordPipe();
                case 1:
                    return new ØstPipe();
                case 2:
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
     
    }
}