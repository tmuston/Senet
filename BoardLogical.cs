using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senet
{
    
    class BoardLogical
    {
        
        public BoardLogical()
        {
            // initialize the board array
            // 0 is empty space
            // 1 is occupied by a player 1 token
            // 2 is occupied by player 2 token
            // 4 is the ankh square - square 14
            // 8 is the house of happiness
            // 16 is the house of water
            // 32 is the house of three truths
            // 64 is the eye of Horus
            for(int i = 0; i<30; i++)
            {// first, set everything empty
                lBoard[i] = 0;
            }
            lBoard[14] = 4;
            lBoard[24] = 8;
            lBoard[25] = 16;
            lBoard[26] = 32;
            lBoard[27] = 64;



        }
        // lBoard elements can have a value indicating the first or second player
        // 
        private int[] lBoard = new int[30];
    }
}
