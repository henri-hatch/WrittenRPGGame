namespace WrittenRPGGame;

public class Interactions : Game
{
    protected static List<string> interactionsList = new();
    
    
    public static void SetInteractLists(int currentLevel)
    {
        switch (currentLevel)
        {
            // Level One
             case 1:
                 interactionsList.Add("1. Chains");
                 interactionsList.Add("2. Loose Rocks");
                 interactionsList.Add("3. The Heap of Cloth on the Ground");
                 interactionsList.Add("4. The Door");
                 interactionsList.Add("5. The Window");
                 break;
             // Level Two
             case 2:
                 interactionsList.Clear();
                 
                 interactionsList.Add("1. Test");
                 break;
                 
        }
    }

    // Links to all interaction prints.
    public static int Print(int currentStage)
    {

        int choice = 0;
        
        switch (currentStage)
        {
            
            case 1:
                choice = levelOne.InteractPrint();
                break;
            case 2:
                choice = levelTwo.InteractPrint();
                break;
        }

        return choice;
    }

    // Links to all interaction choices.
    public static bool Choice(int currentStage, int choice)
    {

        bool finishLevel = false;
        
        switch (currentStage)
        {
            
            case 1:
                finishLevel = levelOne.Interact(choice);
                break;
        }

        return finishLevel;
    }
    public static void ActionText(string str)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("*"+str+"*");
        Console.ResetColor();
    }

    public static void PositiveStatusText(string str)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(str);
        Console.ResetColor();
    }

    public static void NegativeStatusText(string str)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(str);
        Console.ResetColor();
    }

    public static void InventoryUpdateText(string str)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("[" + str + "]");
        Console.ResetColor();
    }
}