using System.Formats.Asn1;
using System.IO;

namespace WrittenRPGGame;

public class Game
{
    // This is for the game constructor that runs the whole thing, pulling methods from separate classes.
    
    protected static Player _player;
    
    // Pull from file, do not set as 1 every time.
    protected static int CurrentStory;
    
    public static void GameInit()
    {

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
                _player.Blessing = Convert.ToInt32(lines[3]);
                _player.Armor = Convert.ToInt32(lines[4]);
                _player.Exp = Convert.ToInt32(lines[5]);
                _player.Level = Convert.ToInt32(lines[6]);
                _player.Gold = Convert.ToInt32(lines[7]);
                CurrentStory = Convert.ToInt32(lines[8]);
            }
        }

        else
        {
            _player = new Player();
            
            _player.CurrentHp = 100;
            _player.MaxHp = 100;
            _player.Strength = 1;
            // _player.Agility = 1;
            // _player.Dexterity = 1;
            _player.Armor = 1;
            _player.Exp = 0;
            _player.Level = 1;
            _player.Blessing = 1;
            _player.Gold = 0;
        }
    }

    public static void StoryBreak()
    {

        string choice;
        
        Console.Write("\nEnter a command or press <Enter> to continue. Type 'help' for a list of all available" +
                          " commands. >> ");
        choice = Console.ReadLine();

        switch (choice)
        {
            case "":
                break;
            
            case "look":
                new Commands().Look(CurrentStory);
                StoryBreak();
                break;
            
            case "help":
                new Commands().Help();
                StoryBreak();
                break;
            
            case "stats":
                new Commands().Stats();
                StoryBreak();
                break;
            
            case "save":
                new Commands().Save();
                StoryBreak();
                break;
            
            default:
                Console.WriteLine("Unknown command, please make sure you are spelling it right.");
                StoryBreak();
                break;
        }
    }
    public static void Main(string[] args)
    {

        GameInit();

        Console.Write("Welcome to Heaven's Fall\nPress <Enter> to continue >> ");
        Console.ReadLine();
        
        for (; CurrentStory <= 1; CurrentStory++)
        {
            
            new StoryText().MainStory(CurrentStory);
        }
        
        // Save currentStory to a text file to save and load progress along with player stats.
        // Save the currentStory variable as itself minus 1.

        Console.WriteLine("The program ran successfully.");
    }
}
