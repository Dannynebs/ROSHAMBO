using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_Enums_AbstractClasses
{
    internal class RockPlayer : Player
    {
        public RockPlayer()
        {
            Name = "RockPlayer";
        }
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}
