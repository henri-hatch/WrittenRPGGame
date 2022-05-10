namespace WrittenRPGGame;

public class levelTwo : Interactions
{
    private static bool choiceOne;
    public static int InteractPrint()
    {
        int choice = 0;
    
        Console.WriteLine("Enter an option using the number before each option.");
        for (int i = 0; i < interactionsList.Count; i++)
        {
            switch (i)
            {
                case 0:
                    if (choiceOne)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(interactionsList[i]);
                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        Console.WriteLine(interactionsList[i]);
                        break;
                    }
            }
                    
        }
        
        Console.Write("\nEnter your choice >> ");
        choice = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        return choice;

    }
}