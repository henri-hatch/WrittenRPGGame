using System.Security.Cryptography;

namespace WrittenRPGGame;

public class Checks
{
    static Random rnd = new Random();

    public static bool Check(int stat, int difficulty, string type)
    {
        // Define the variables.
        int randomNum, playerNum;

        // Indicates what type of check is being performed.
        Console.Clear();
        Console.WriteLine(type + " Check!\n");

        // Get a random number between 1 - difficulty
        randomNum = (rnd.Next(difficulty) + 1);

        // Prompt user for random number with a range of 1 - difficulty
        Console.Write("\nEnter a number between 1 and " + (difficulty + stat) + " >> ");
        playerNum = Convert.ToInt32(Console.ReadLine());
        while (playerNum > (difficulty + 1) || playerNum < 1)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("ERROR: Number outside of range");
            Console.ResetColor();
            Console.Write("\nEnter a number between 1 and " + (difficulty + stat) + " >> ");
            playerNum = Convert.ToInt32(Console.ReadLine());
        }




        // Perform the check.
        if ((randomNum - stat) <= playerNum && playerNum <= (randomNum + stat))
        {
            Console.Write("Checking.");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            return true;
        }
        else
        {
            Console.Write("Checking.");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            return false;
        }
    }
}
