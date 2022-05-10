using System.Formats.Asn1;
using System.IO;

namespace WrittenRPGGame;

public class Game
{
    // This is for the game constructor that runs the whole thing, pulling methods from separate classes.
    
    protected static Player _player;
    
    protected static int CurrentStory;
    
    public static List<Item> playerInventory = new List<Item>();

    private static int _currentLevel = 1;

    public static bool NextLevelCheck;
    public static void GameInit()
    {
        
        // Game initializer to pull save files or create new ones, sets up the player.

        if (File.Exists("HFSave"))
        {

            using (var fs = new FileStream("HFSave", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var reader = new StreamReader(fs))
            {
                
                string[] lines = System.IO.File.ReadAllLines("HFSave");

                _player = new Player();

                _player.MaxHp = Convert.ToInt32(lines[0]);
                _player.CurrentHp = Convert.ToInt32(lines[1]);
                _player.Strength = Convert.ToInt32(lines[2]);
                _player.Agility = Convert.ToInt32(lines[3]);
                _player.Dexterity = Convert.ToInt32(lines[4]);
                _player.Blessing = Convert.ToInt32(lines[5]);
                _player.Armor = Convert.ToInt32(lines[6]);
                _player.Exp = Convert.ToInt32(lines[7]);
                _player.Level = Convert.ToInt32(lines[8]);
                _player.Gold = Convert.ToInt32(lines[9]);
                CurrentStory = Convert.ToInt32(lines[10]);
                _player.IsChained = Convert.ToBoolean(lines[11]);
            }
            
        }

        else
        {
            _player = new Player();
            
            _player.CurrentHp = 50;
            _player.MaxHp = 100;
            _player.Strength = 1;
            _player.Agility = 1;
            _player.Dexterity = 1;
            _player.Armor = 0;
            _player.Exp = 0;
            _player.Level = 1;
            _player.Blessing = 1;
            _player.Gold = 0;
            _player.IsChained = true;

            Interactions.SetInteractLists(1);
        }
    }

    public static void StoryBreak()
    {
    
        // Method to put a break in the story.
        
        string choice;
        
        Console.Write("\nEnter a command. Type 'help' for a list of all available commands. >> ");
        choice = Console.ReadLine();

        switch (choice)
        {
            // Look command
            case "look":
                new Commands().Look(CurrentStory);
                StoryBreak();
                break;
            
            // Displays list of commands
            case "help":
                new Commands().Help();
                StoryBreak();
                break;
            
            // Displays player stats
            case "stats":
                new Commands().Stats();
                StoryBreak();
                break;
            
            // Saves and quits the game
            case "save":
                new Commands().Save();
                StoryBreak();
                break;
            
            // Shows all interactions
            case "interact":
                NextLevelCheck = Commands.Interact(_currentLevel);
                if (NextLevelCheck)
                {
                    NextLevel();
                    break;
                }
                StoryBreak();
                break;
            
            // Displays inventory
            case "inventory":
                new Commands().Inventory();
                StoryBreak();
                break;
            
            // Test command, remove later
            case "additem":
                Inventory.AddItem("potion", 1);
                Console.WriteLine("Successfully added item.");
                StoryBreak();
                break;
            
            // Removes and drops an amount of an item
            case "remove":
                Commands.RemoveItem();
                StoryBreak();
                break;
            
            // Uses an item in your inventory
            case "use":
                Commands.UseItem();
                StoryBreak();
                break;
            
            // When in doubt
            default:
                Console.WriteLine("Unknown command, please make sure you are spelling it right.");
                StoryBreak();
                break;
        }
    }
    
    public static void Main(string[] args)
    {

        // Main method that runs the whole thing.
        
        GameInit();
        
        Console.WriteLine("Welcome to Heaven's Fall");

        if (File.Exists("HFSave"))
        {
            
            Console.WriteLine("\nA previous save file was detected, you will start where you left off.");
        }

        else
        {

            Console.WriteLine("No save file detected, a new one will be created.");
        }
        
        Console.Write("\nPress <Enter> to continue >> ");
        Console.ReadLine();
        
        // This makes the story go.
        for (; CurrentStory <= 5; CurrentStory++)
        {
            
            StoryText.MainStory(CurrentStory);
        }

        Console.WriteLine("The program ran successfully.");
    }
    public static void NextLevel()
    {
        _currentLevel++;
        NextLevelCheck = false;
        Interactions.SetInteractLists(_currentLevel);
    }
}
