
/*
The application asks the user to enter the number of sides for a pair of dice. 
If you have learned about exception handling, make sure the user can only enter numbers
The application prompts the user to roll the dice.
The application “rolls” two n-sided dice, displaying the results of each along with a total
For 6-sided dice, the application recognizes the following dice combinations and displays a message for each. It should not output this for any other size of dice.
Snake Eyes: Two 1s
Ace Deuce: A 1 and 2
Box Cars: Two 6s
Win: A total of 7 or 11
Craps: A total of 2, 3, or 12 (will also generate another message!)
The application asks the user if he/she wants to roll the dice again.
*/

/*
Console.WriteLine("Enter the number of sides for a pair of dice");

Random randomNum = new Random();

int GenerateRandomNumber()
{
    Random randomNum = new Random();
    int randomNumber = 0;
    randomNumber= randomNum.Next(12);
    return randomNumber;
}
int GenerateRandomNumberWProvidedMinAndMix(int minValue, int maxValue)
{
    Random randomNum = new Random();
    int randomNumber = 0;
    randomNumber = randomNum.Next(minValue,maxValue);
    return randomNumber;
}
string HandleDice(int diceOne, int diceTwo)
{
    string message = "";
    // do logic to get the right string
    return message;
}
int GetDiceSides(int getSides)
{
    Console.WriteLine("Enter the number of sides for a pair of dice");
    int numberOfSides = int.Parse(Console.ReadLine());
}
*/


using System.ComponentModel.Design;
Console.WriteLine("Welcome to the Grand Circus Casino!");
Console.WriteLine("Enter the number of sides for a pair of dice");
string userInput = Console.ReadLine();
int userNumber = 0;
bool isRealNumber = int.TryParse(userInput, out userNumber);

// if user gives invalid number 
while (isRealNumber == false)
{
    Console.WriteLine("You must enter a number. Try again");
    userInput = Console.ReadLine();
    isRealNumber = int.TryParse(userInput, out userNumber); // Parse again
}


if (userNumber == 6)
{
    bool playAgainAnswer = false;
    do
    {
        int diceRollOne = GenerateRandomNumber(userNumber);
        int diceRollTwo = GenerateRandomNumber(userNumber);
        int sum = diceRollOne + diceRollTwo;

        Console.WriteLine("Press any key to roll the dice.");
        Console.ReadKey(); // Waits for user to press a key to continue
        Console.WriteLine($"You rolled a {diceRollOne} and a {diceRollTwo}. The total is {sum}");

        string result = HandleSixSidedDice(diceRollOne, diceRollTwo);
        string result2 = HandleSixSidedDiceTotal(diceRollOne, diceRollTwo);
        Console.WriteLine(result);
        Console.WriteLine(result2);

        playAgainAnswer = GetPlayAgainAnswer();

    } while (playAgainAnswer == true);

}  
// IF user number is 6
//Call methods, and get their messages
// Display those messages




















// #1
int GenerateRandomNumber(int numberOfSides)
{
    Random randomNum = new Random();
    int randomNumber = 0;
    randomNumber = randomNum.Next(1, numberOfSides + 1); //Number from 1 to side of die input
    return randomNumber;
}
// #2
string HandleSixSidedDice(int diceOne, int diceTwo)
{
    if (diceOne == 1 && diceTwo == 1)
    { return "Snake Eyes"; }
    else if (diceOne + diceTwo == 3)
    { return "Ace Deuce"; }
    else if (diceOne + diceTwo == 12)
    { return "Box Cars"; }
    else
    {
        return "";
    }
}

string HandleSixSidedDiceTotal(int diceOne, int diceTwo)
{
    int sum = diceOne + diceTwo;
    if (sum == 7 || sum == 11)
    { return "Win"; }
    if (sum == 2 || sum == 3 || sum == 12)
    { return "Craps"; }
    return "";
}
string HandleSixSidedDiceSwitch(int diceOne, int diceTwo)
{
    int sum = diceOne + diceTwo;
    switch (sum)
    {
        case 2:
            return "Snake Eyes";
        case 3:
            return "Ace Duece";
        case 4:
            return "Box cars";
        default:
            return "";
    }
}
bool GetPlayAgainAnswer()
{
    Console.WriteLine("Would you like play again? Anything but 'yes' will end the game.");
    string userAnswer = Console.ReadLine();
    if (userAnswer.ToLower() != "yes")
    {
        return false;
    }
    else
    {
        Console.WriteLine("YEAH LETS PLAY");
        return true;
    }
}
