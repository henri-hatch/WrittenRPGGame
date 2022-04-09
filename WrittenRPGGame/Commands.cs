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

    public void Look(int currentStage)
    {

        switch (currentStage)
        {
            
            case 1:
                
                Console.WriteLine("\nYou are in a stone cell, just big enough for one person.\n" +
                                  "The cell is ancient, with mold and hundreds of cracks lining the walls and ceiling.\n" +
                                  "You are held to the wall by a set of chains, your wrists bound by rusty steel.\n" +
                                  "A window must be above you, as bright sunlight is filtering onto a square of light\n" +
                                  "on the floor in front of you. Directly in front of you is a rusty, metal door.\n" +
                                  "Loose stones, about the size of your fist, litter your cell floor.\n" +
                                  "In the far corner of the room, to the right of the door,\n" +
                                  "lies a heap of cloth, and something…else.");
                break;
        }
    }
}