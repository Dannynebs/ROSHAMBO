// See https://aka.ms/new-console-template for more information
using Roshambo_Enums_AbstractClasses;



HumanPlayer user = new HumanPlayer();
HumanPlayer enemyHuman = new HumanPlayer();
RockPlayer rockPlayer = new RockPlayer();
RandomPlayer randomPlayer = new RandomPlayer();
Console.WriteLine("What is your name?");
user.Name = Console.ReadLine();

do
{
    string message = "Who will you face in battle? Enter 1 for a Rock Player, 2 for a random player, or 3 for a human player";
    int userOpponent = Validator.GetIntegerFromUser(message);

    while (Validator.NumberIsInRange(userOpponent) == false)
    {
        Console.WriteLine("The number must be 1-3, corresponding to an opponent");
    }



    Roshambo userChoice;
    Roshambo opponentChoice;
    switch (userOpponent)
    {
        case 1:
            userChoice = user.GenerateRoshambo();
            opponentChoice = rockPlayer.GenerateRoshambo();
            if (userChoice == Roshambo.Rock)
            {
                Console.WriteLine("You both played Rock! It's a draw!");
            }
            if (userChoice == Roshambo.Scissors)
            {
                Console.WriteLine($"{user.Name}: {userChoice} ");
                Console.WriteLine($"{enemyHuman.Name}: {opponentChoice} ");
                Console.WriteLine($"{enemyHuman.Name} wins!");
            }
            if (userChoice == Roshambo.Paper)
            {
                Console.WriteLine($"{user.Name}: {userChoice} ");
                Console.WriteLine($"{enemyHuman.Name}: {opponentChoice} ");
                Console.WriteLine($"{user.Name} wins!");
            }
            break;

        case 2:
            userChoice = user.GenerateRoshambo();
            opponentChoice = randomPlayer.GenerateRoshambo();
            if (userChoice == Roshambo.Rock && opponentChoice == Roshambo.Rock || userChoice == Roshambo.Scissors && opponentChoice == Roshambo.Scissors || userChoice == Roshambo.Paper && opponentChoice == Roshambo.Paper)
            {
                Console.WriteLine($"{user.Name}: {userChoice} ");
                Console.WriteLine($"{enemyHuman.Name}: {opponentChoice} ");
                Console.WriteLine("You played the same hand! It's a draw!");
            }
            if (userChoice == Roshambo.Scissors && opponentChoice == Roshambo.Paper || userChoice == Roshambo.Paper && opponentChoice == Roshambo.Rock || userChoice == Roshambo.Rock && opponentChoice == Roshambo.Scissors)
            {
                Console.WriteLine($"{user.Name}: {userChoice} ");
                Console.WriteLine($"{enemyHuman.Name}: {opponentChoice} ");
                Console.WriteLine($"{user.Name} wins!");
            }
            if (userChoice == Roshambo.Paper && opponentChoice == Roshambo.Scissors || userChoice == Roshambo.Rock && opponentChoice == Roshambo.Paper || userChoice == Roshambo.Scissors && opponentChoice == Roshambo.Rock)
            {
                Console.WriteLine($"{user.Name}: {userChoice} ");
                Console.WriteLine($"{enemyHuman.Name}: {opponentChoice} ");
                Console.WriteLine($"{enemyHuman.Name} wins!");
            }
            break;

        default:
            userChoice = user.GenerateRoshambo();
            opponentChoice = enemyHuman.GenerateRoshambo();
            if (userChoice == Roshambo.Rock && opponentChoice == Roshambo.Rock || userChoice == Roshambo.Scissors && opponentChoice == Roshambo.Scissors || userChoice == Roshambo.Paper && opponentChoice == Roshambo.Paper)
            {
                Console.WriteLine($"{user.Name}: {userChoice} ");
                Console.WriteLine($"{enemyHuman.Name}: {opponentChoice} ");
                Console.WriteLine("You played the same hand! It's a draw!");
            }
            if (userChoice == Roshambo.Scissors && opponentChoice == Roshambo.Paper || userChoice == Roshambo.Paper && opponentChoice == Roshambo.Rock || userChoice == Roshambo.Rock && opponentChoice == Roshambo.Scissors)
            {
                Console.WriteLine($"{user.Name}: {userChoice} ");
                Console.WriteLine($"{enemyHuman.Name}: {opponentChoice} ");
                Console.WriteLine($"{user.Name} wins!");
            }
            if (userChoice == Roshambo.Paper && opponentChoice == Roshambo.Scissors || userChoice == Roshambo.Rock && opponentChoice == Roshambo.Paper || userChoice == Roshambo.Scissors && opponentChoice == Roshambo.Rock)
            {
                Console.WriteLine($"{user.Name}: {userChoice} ");
                Console.WriteLine($"{enemyHuman.Name}: {opponentChoice} ");
                Console.WriteLine($"{enemyHuman.Name} wins!");
            }
            break;
    }
    Validator.GetPlayAgainAnswer();
} while (Validator.GetPlayAgainAnswer() == true);

// You still need to do validations. Validator class is probably easier.
// The challenges are doable.















//string message = "Who will you face in battle? Enter 1 for a Rock Player, 2 for a random player, or 3 for a human player";
//int userOpponent = Validator.GetIntegerFromUser(message);

//while (Validator.NumberIsInRange(userOpponent) == false)
//{
//    Console.WriteLine("The number must be 1-3, corresponding to an opponent");
//}




//Console.WriteLine("Who will you face in battle? Enter 1 for a Rock Player, 2 for a random player, or 3 for a human player");
//string userInput = Console.ReadLine();
//int userOpponent;
//bool isValidNumber = int.TryParse(userInput, out userOpponent);

//while (isValidNumber == false)
//{
//    Console.WriteLine("You must enter a number.");
//    isValidNumber = int.TryParse(userInput, out userOpponent);
//    while (Validator.NumberIsInRange(userOpponent) == false)
//    {
//        Console.WriteLine("The number must be 1-3, corresponding to an opponent");
//    }
//}