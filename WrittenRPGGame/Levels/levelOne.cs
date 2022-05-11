namespace WrittenRPGGame;

public class levelOne : Interactions
{
    
    private static bool _doorOpened = false;
    private static bool _examinedWindow = false;

    public static bool LevelOneInteract(int choice)
    {
        bool containsRock = playerInventory.Any(item => item.Name == "Rock");
        
        switch (choice)
        {
                    
            // Chains Interaction
            case 1:
                if (OneIsUsed)
                {
                    return Commands.Interact(1);
                    break;
                }
                else if (_player.IsChained && !containsRock)
                {
                    ActionText("You attempt to break the chains"); 
                    System.Threading.Thread.Sleep(2000);    // Pauses for two seconds.

                    // Performs the check
                    if (Checks.Check(_player.Strength, 5, "Strength"))
                    {
                        _player.IsChained = false;
                        PositiveStatusText("You are no longer chained!");
                    }
                    else
                    {
                        NegativeStatusText("You didn't pass the Strength check, and you are still chained.");
                        break;
                    }
                }
                else if (_player.IsChained && containsRock)
                {
                            
                    ActionText("You use the rock to break the chains");
                    System.Threading.Thread.Sleep(1000);
                    _player.IsChained = false;
                    PositiveStatusText("You are no longer chained!");  

                }
                else
                {
                    Console.WriteLine("You look at the chains and notice that they are rusty");
                    OneIsUsed = true;
                }
                break;
                    
            // Stones Interaction
            case 2:
                if (TwoIsUsed)
                {
                    return Commands.Interact(1);
                    break;
                }
                ActionText("You pick up the rock");
                Inventory.AddItem("Rock", 1);   // Adds the rock to the player's inventory.
                InventoryUpdateText("+1 Rock");
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("It is rough and hard, fist sized, perfect for breaking things and possibly" +
                                  " denting something's skull.");
                TwoIsUsed = true;
                break;
                    
            // The Heap of Cloth on the Ground Interaction
            case 3:
                if (ThreeIsUsed)
                {
                    return Commands.Interact(1);
                    break;
                }
                Console.WriteLine("Bones and dried flesh peek out from under black cloth. You step closer, " +
                                  "and see that it's a dead imp. Its jaw bone is missing, and its bony " +
                                  "fingers are clutched around a vile of red liquid.");
                System.Threading.Thread.Sleep(5000);
                ActionText("You pick up the vile on the ground");
                Inventory.AddItem("Potion", 1);
                InventoryUpdateText("+1 Potion");
                Console.WriteLine("\tA potion restores 50 HP!");
                ThreeIsUsed = true;
                break;
                    
            // Door Interactions
            case 4:
                if (FourIsUsed)
                {
                    return Commands.Interact(1);
                    break;
                }
                else if (_player.IsChained)
                {
                    ActionText("You examine the door");
                    Console.WriteLine("The door is rusty and old. Two hinges hold it to the wall and a rusty " +
                                      "lock holds the iron shut.");
                }
                else if (!_doorOpened && !_player.IsChained)
                {
                    ActionText("You open the door");
                    return true;
                }
                else
                {
                    ActionText("You examine the door");
                    Console.WriteLine("It is a rusty and broken door.");
                }
                break;
                    
            // Window Interaction
            case 5:
                if (FiveIsUsed)
                {
                    return Commands.Interact(1);
                    break;
                }
                if (!_examinedWindow)
                {
                    _examinedWindow = true;
                    ActionText("You examine the window");
                    System.Threading.Thread.Sleep(1000);    // Pauses the console for 1 second.
                    Console.WriteLine("Three rusty, metal bars stand embedded in stone, separating you from " +
                                      "a bright blue sky and a darker blue sea that stretches for miles " +
                                      "before you.");
                }
                else
                {
                    ActionText("You examine the window");
                    Console.WriteLine("It is the same window as before.");
                    FiveIsUsed = true;
                }
                break;
                        
        }
                
        return false;
    }
}
