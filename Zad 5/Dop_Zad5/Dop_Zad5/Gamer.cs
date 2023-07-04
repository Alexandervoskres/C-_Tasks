using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop_Zad5
{
    internal class Gamer
    {
        string name;
        Dice seans;
        public Gamer(string name)
        {
            this.name = name;
            seans = new Dice();
        }
        public int SeansGame()
        {
            int alpha = seans.Roll();
            if (alpha == 6)
            {
                ScoreNotify?.Invoke("Бинго! Выпало 6 очков.");
            }
            return alpha;
        }
        public override string ToString()
        {
            return name;
        }

        public delegate void MaxScore(string message);
        public event MaxScore ScoreNotify;

    }
}
