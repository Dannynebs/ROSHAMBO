using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_Enums_AbstractClasses
{
    public class Validator
    {
        public static bool GetPlayAgainAnswer()
        {
            Console.WriteLine("Would you like play again. Anything but 'yes' will end the game.");
            string userAnswer = Console.ReadLine();
            if (userAnswer.ToLower() != "yes")
            {
                return false;
            }

            Console.WriteLine("YEAH LETS PLAY");
            return true;
        }

        public static bool NumberIsInRange(int userNumber)
        {

            if (userNumber >= 1 && userNumber <= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int GetIntegerFromUser(string message)
        {
            bool isInvalidInteger = false;
            int returnValue = -1;

            while (isInvalidInteger == false)
            {
                // Write the message to the console
                Console.WriteLine(message); 
                try
                {
                    // Tries to parse the entered value
                    returnValue = int.Parse(Console.ReadLine());

                }
                catch
                {
                    // if bad value start loop again with "continue" jump statement
                    Console.WriteLine("You need to enter a valid integer");
                    continue;
                }

                isInvalidInteger = true;
            }

            return returnValue;
        }
    }
}
