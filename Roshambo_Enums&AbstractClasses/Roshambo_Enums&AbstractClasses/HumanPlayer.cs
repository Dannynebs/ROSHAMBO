using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_Enums_AbstractClasses
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer()
        {
            Name = "TheOpponent";
        }
        public override Roshambo GenerateRoshambo()
        {
            Console.WriteLine("Enter the number you want to throw: Rock(0), Paper(1), Scissors (2)");
            int userChoice = int.Parse(Console.ReadLine());
            Roshambo roshamboChoice = (Roshambo)userChoice;
            return roshamboChoice;
        }
    }
}
