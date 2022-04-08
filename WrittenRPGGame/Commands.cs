namespace WrittenRPGGame;

public class Commands : Game
{
    
    // This will hold all possible commands such as 'look'. Any of these methods should be called whenever a player
    // types the keyword when given a break in the story, keep them small and non-disruptive towards the story.
    
    public void Help()
    {

        Console.WriteLine("Possible commands are: \n\t 'help' \n\t 'look' \n\t 'stats'");
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
}