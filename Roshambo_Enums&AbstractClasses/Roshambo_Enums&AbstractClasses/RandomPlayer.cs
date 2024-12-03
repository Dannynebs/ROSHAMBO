using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_Enums_AbstractClasses
{
    internal class RandomPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            Random random = new Random();
            int rnd = random.Next(0, 3);
            Roshambo rndChoice = (Roshambo)rnd;
            return rndChoice;
        }
    }
}
