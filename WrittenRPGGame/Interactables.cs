namespace WrittenRPGGame;

public class Interactables : Game
{
    // This will contain all interactables in each stage when looking. Each item will be contained in a list
    // and can be looped through to list and interact with each item. Some can be picked up, others cannot.

    public static List<string> areaOne = new List<string>();
    private static bool _doorOpened = false;
    private static bool _examinedWindow = false;
    
    public void SetInteractLists()
    {

        areaOne.Add("1. Chains");
        areaOne.Add("2. Loose Rocks");
        areaOne.Add("3. The Heap of Cloth on the Ground");
        areaOne.Add("4. The Door");
        areaOne.Add("5. The Window");
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


    public static bool InteractChoices(int currentStory, int choice)
    {
        bool containsRock = playerInventory.Any(item => item.Name == "Rock");
        switch (currentStory)
        {
            case 1:
                
                
                switch (choice)
                {
                    
                    // Chains Interaction
                    case 1:
                        
                        if (_player.IsChained && !containsRock)
                        {
                            Console.WriteLine("\nYou attempt to break the chains");
                            // Strength CHECK
                        }
                        else if (_player.IsChained && containsRock)
                        {
                            Console.WriteLine("You use the rock to break the chains");
                            Console.WriteLine("*You are now freed from the chains*");   // Italicized
                            _player.IsChained = false;
                        }
                        else
                        {
                            Console.WriteLine("You look at the chains and notice that they are rusty");
                        }
                        break;
                    
                    // Stones Interaction
                    case 2:
                        Console.WriteLine("*You pick up the rock*");    // Italicized
                        Inventory.addItem("Rock", "Rock", 1);
                        Console.WriteLine("[+1 Rock]"); // Format for inventory text.
                        Console.WriteLine("...");
                        // Add in a pause, then print the following.
                        Console.WriteLine("It is rough and hard, fist sized, perfect for breaking things and possibly" +
                                          " denting something's skull.");
                        break;
                    
                    // The Heap of Cloth on the Ground Interaction
                    case 3:
                        Console.WriteLine("Bones and dried flesh peek out from under black cloth. You step closer, " +
                                          "and see that it's a dead imp. Its jaw bone is missing, and its bony " +
                                          "fingers are clutched around a vile of red liquid.");
                        Console.WriteLine("[+1 Potion] - Restores 50 HP");   // format string for inventory update text.
                        break;
                    
                    // Door Interactions
                    case 4:
                        if (_player.IsChained)
                        {
                            Console.WriteLine("*You examine the door*");    // Italicized
                            Console.WriteLine("The door is rusty and old. Two hinges hold it to the wall and a rusty " +
                                              "lock holds the iron shut.");
                        }
                        else if (!_doorOpened && !_player.IsChained)
                        {
                            Console.WriteLine("*You open the door*");   // Italicized
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("*You examine the door*");    // Italicized
                            Console.WriteLine("It is a rusty and broken door.");
                        }
                        break;
                    
                    // Window Interaction
                    case 5:
                        if (!_examinedWindow)
                        {
                            _examinedWindow = true;
                            Console.WriteLine("*You examine the window*");  // Italicized
                            Console.WriteLine("Three rusty, metal bars stand embedded in stone, separating you from " +
                                              "a bright blue sky and a darker blue sea that stretches for miles " +
                                              "before you.");
                        }
                        else
                        {
                            Console.WriteLine("*You examine the window*");
                            Console.WriteLine("It is the same window as before.");
                        }
                        break;
                        
                }

                
                break;
        }
        return false;
    }
}
