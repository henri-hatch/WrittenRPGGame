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
        _player.Intelligence = 1;
        _player.Gold = 0;
    }
    public static void Main(string[] args)
    {
        bool initialText = new StoryText().InitialText();
        Console.WriteLine("The program ran successfully.");
    }
}
