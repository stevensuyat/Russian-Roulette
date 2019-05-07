using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_Roulette
{
    public class GamePlay
    {
        public int BalloonsLoaded;
        public int BalloonsLeft;
        public int DdgBalloon;
        public int PaintBalloon;
        public int Wins;
        public int Losses;
        public int RndNumGen()
        {
            Random RndNum = new Random();
            return RndNum.Next(4, 7);
        }

        public int PaintBalloonGen()
        {
            Random RndPaintBalloon = new Random();
            return RndPaintBalloon.Next(1, 5);
        }

    }
}
