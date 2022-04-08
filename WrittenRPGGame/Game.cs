namespace WrittenRPGGame;

public class Game
{
    // This is for the game constructor that runs the whole thing, pulling methods from separate classes.
    
    protected Player _player;

    public void GameInit()
    {

        _player = new Player();

        _player.CurrentHp = 100;
        _player.MaxHp = 100;
        _player.Strength = 1;
        _player.Armor = 1;
        _player.Exp = 0;
        _player.Level = 1;
        _player.Blessing = 1;
        _player.Gold = 0;
    }

    public static void StoryBreak()
    {

        String choice;

        Console.Write("\nTo continue, press <Enter>, otherwise you may use another command. If you are unsure" +
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
                Console.WriteLine("Helping");
                break;
            
            default:
                Console.WriteLine("Unknown command, please make sure you are spelling it right.");
                StoryBreak();
                break;
        }
    }
    public static void Main(string[] args)
    {
        bool initialText = new StoryText().InitialText();

        StoryBreak();
        
        Console.WriteLine("The program ran successfully.");
    }
}
