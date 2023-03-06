using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalCasino
{
    internal class Coin
    {
        int NumFlips, numHeads, numTails;
        public Coin(int numFlips)
        {
            NumFlips = numFlips;
        }

        public void Flip()
        {
            var rng = new Random();
            for(int i = 0; i < NumFlips; i++)
            {
                switch(rng.Next(2))
                {
                    case 0:
                        Console.Write("T");
                        numTails++;
                        break;
                    case 1:
                        Console.Write("H");
                        numHeads++;
                        break;
                }
            }
            Console.WriteLine($"\nYou got {numHeads} heads and {numTails} tails!\n");
        }
    }
}
