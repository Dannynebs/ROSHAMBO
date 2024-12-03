using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_Enums_AbstractClasses
{
    internal abstract class Player
    {
        public string Name { get; set; }

        public abstract Roshambo GenerateRoshambo();
    }
}
