namespace WrittenRPGGame;

public class Interactions : Game
{
    
    protected static List<string> levelOneList = new List<string>();
    
    public static void SetInteractLists()
    {

        // Level One
        levelOneList.Add("1. Chains");
        levelOneList.Add("2. Loose Rocks");
        levelOneList.Add("3. The Heap of Cloth on the Ground");
        levelOneList.Add("4. The Door");
        levelOneList.Add("5. The Window");
    }

    // Links to all interaction prints.
    public static int Print(int currentStage)
    {

        int choice = 0;
        
        switch (currentStage)
        {
            
            case 1:
                choice = levelOne.InteractPrint(currentStage);
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
                finishLevel = levelOne.InteractChoices(currentStage, choice);
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