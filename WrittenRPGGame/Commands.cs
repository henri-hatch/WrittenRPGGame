using System.Security.AccessControl;

namespace WrittenRPGGame;

public class Commands : Game
{
    
    // This will hold all possible commands such as 'look'. Any of these methods should be called whenever a player
    // types the keyword when given a break in the story, keep them small and non-disruptive towards the story.
    
    public void Help()
    {

        Console.WriteLine("Possible commands are: \n\t 'help' \n\t 'look' \n\t 'stats' \n\t 'interact' \n\t " +
                          "'save' \n\t 'remove' \n\t 'inventory'");
    }

    public void Stats()
    {

        Console.WriteLine("\nMax HP: " + _player.MaxHp);
        Console.WriteLine("Current HP: " + _player.CurrentHp);
        Console.WriteLine("Strength: " + _player.Strength);
        Console.WriteLine("Blessing: " + _player.Blessing);
        Console.WriteLine("Armor Class: " + _player.Armor);
        Console.WriteLine("Current EXP: " + _player.Exp);
        Console.WriteLine("Level: " + _player.Level);
        Console.WriteLine("\nGold: " + _player.Gold);
    }

    public void Look(int currentStage)
    {

        StoryText.LookStory(currentStage); 
    }

    public void Interact(int currentStage)
    {
        
        int choice;
        choice = Interactables.Interact(currentStage);
        new StoryText().InteractStory(currentStage, choice);
    }

    public void Inventory()
    {
        
        // Shows Inventory
        int num = 1;
        
        foreach (Item items in playerInventory)
        {
            
            Console.WriteLine(num + ") " + items.Quantity + " " + items.Name);
        }
    }

    public static void RemoveItem()
    {

        Console.Write("\nWhat would you like to remove? >> ");
        string name = Console.ReadLine();
        
        Console.Write("\nHow many of said item would you like to remove? >> ");
        int quantity = Convert.ToInt32(Console.ReadLine());
        
        WrittenRPGGame.Inventory.removeItem(name, quantity);
    }

    public void Save()
    {

        string saveOrNo;
        Console.Write("\nWould you like to save and quit? (y/n) >> ");
        saveOrNo = Console.ReadLine();

        switch (saveOrNo)
        {
            
            case "y":

                using (StreamWriter file = new StreamWriter("HFSave"))
                {
                    file.WriteLine(_player.MaxHp.ToString());
                    file.WriteLine(_player.CurrentHp.ToString());
                    file.WriteLine(_player.Strength.ToString());
                    file.WriteLine(_player.Agility.ToString());
                    file.WriteLine(_player.Dexterity.ToString());
                    file.WriteLine(_player.Blessing.ToString());
                    file.WriteLine(_player.Armor.ToString());
                    file.WriteLine(_player.Exp.ToString());
                    file.WriteLine(_player.Level.ToString());
                    file.WriteLine(_player.Gold.ToString());
                    file.WriteLine(CurrentStory.ToString());
                }
                
                Environment.Exit(0);
                break;
            
            default:
                break;
        }
    }
}