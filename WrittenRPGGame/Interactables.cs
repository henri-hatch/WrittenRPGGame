namespace WrittenRPGGame;

public class Interactables : Game
{
    // This will contain all interactables in each stage when looking. Each item will be contained in a list
    // and can be looped through to list and interact with each item. Some can be picked up, others cannot.

    public static List<string> areaOne = new List<string>();
    
    public void SetInteractLists()
    {

        areaOne.Add("1. Chains");
        areaOne.Add("2. Loose Stones");
        areaOne.Add("3. The Door");
        areaOne.Add("4. The Window");
        areaOne.Add("5. Heap of Cloth on the Ground");
    }

    public static int Interact(int currentStory)
    {

        int choice = 0;

        Console.WriteLine("Enter an option using the number before each option.");
        switch (currentStory)
        {
            
            case 1:
                for (int i = 0; i < areaOne.Count; i++)
                {
                    
                    Console.WriteLine(areaOne[i]);
                }
                
                Console.Write("\nEnter your choice >> ");
                choice = Convert.ToInt32(Console.ReadLine());

                break;
        }

        return choice;
    }


    public static void InteractChoices(int currentStory, int choice)
    {
        switch (currentStory)
        {
            case 1:
                switch (choice)
                {
                    case 1:
                        bool containsRock = playerInventory.Any(item => item.Name == "Rock");
                        if (_player.Chained && !containsRock)
                        {
                            Console.WriteLine("\nYou attempt to break the chains");
                            // Strength CHECK 
                        }
                        else if (_player.Chained && containsRock)
                        {
                            Console.WriteLine("You use the rock to break the chains");
                        }
                        else
                        {
                            Console.WriteLine("You look at the chains and notice that they are rusty");
                        }
                        break;
                    case 2:
                        break;
                }

                break;
        }
    }
}
