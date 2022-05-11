namespace WrittenRPGGame;

public class Interactions : Game
{
    protected static List<string> interactionsList = new();

    public static bool
        OneIsUsed,
        TwoIsUsed,
        ThreeIsUsed,
        FourIsUsed,
        FiveIsUsed;
    
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
                 ResetUsedChoices();
                 break;
             // Level Two
             case 2:
                 interactionsList.Clear();
                 interactionsList.Add("1. Test");
                 ResetUsedChoices();
                 break;
                 
        }
    }

    public static void ResetUsedChoices()
    {
        OneIsUsed = false;
        TwoIsUsed = false;
        ThreeIsUsed = false;
        FourIsUsed = false;
        FiveIsUsed = false;
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
    
    public static int InteractPrint()
    {
        
        int choice = 0;
    
        Console.WriteLine("Enter an option using the number before each option.");
        
        
        for (int i = 0; i < interactionsList.Count; i++)
        {
            switch (i)
            {
                case 0:
                    if (OneIsUsed)
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
                case 1:
                    if (TwoIsUsed)
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
                case 2:
                    if (ThreeIsUsed)
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
                case 3:
                    if (FourIsUsed)
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
                case 4:
                    if (FiveIsUsed)
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