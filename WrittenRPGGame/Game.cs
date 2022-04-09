namespace WrittenRPGGame;

public class Game
{
    // This is for the game constructor that runs the whole thing, pulling methods from separate classes.
    
    protected static Player _player;
    
    // Pull from file, do not set as 1 every time.
    private static int _currentStory = 1;

    public static void GameInit()
    {

        _player = new Player();

        _player.CurrentHp = 100;
        _player.MaxHp = 100;
        _player.Strength = 1;
        _player.Agility = 1;
        _player.Dexterity = 1;
        _player.Armor = 1;
        _player.Exp = 0;
        _player.Level = 1;
        _player.Blessing = 1;
        _player.Gold = 0;
    }

    public static void StoryBreak()
    {

        String choice;

        Console.Write("\n\nTo continue, press <Enter>, otherwise you may use another command. If you are unsure" +
                          " of what commands you can use, type 'help' >> ");
        choice = Console.ReadLine();

        switch (choice)
        {
            case "":
                break;
            
            case "look":
                Console.WriteLine("Looking");
                break;
            
            case "help":
                new Commands().Help();
                StoryBreak();
                break;
            
            case "stats":
                new Commands().Stats();
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
        
        for (; _currentStory <= 1; _currentStory++)
        {
            
            new StoryText().MainStory(_currentStory);
        }
        
        // Save currentStory to a text file to save and load progress along with player stats.
        // Save the currentStory variable as itself minus 1

        Console.WriteLine("The program ran successfully.");
    }
}
