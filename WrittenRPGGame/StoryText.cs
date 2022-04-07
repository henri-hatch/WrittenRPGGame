namespace WrittenRPGGame;

public class StoryText
{
    // This is for all story text and text blocks in general. Should have legible keywords for method names.
    // Return some sort of value at the end tell the game that this sect is over and to continue to the next section.
    // If there is some sort of choice involved, return an integer, otherwise just return true as a boolean.

    public bool InitialText()
    {
        
        Console.Write("Welcome to *Insert World Name*." +
                      "\nPress <Enter> to continue >> ");
        Console.ReadLine();
        Console.Write("You awake in a crumbling stone room, the walls seem to be ancient and you feel cuffs\n" +
                          "around your wrists. You have no memory or recollection of who you are, where you are,\n" +
                          "or how you got here." +
                          "\nPress <Enter> to continue >> ");
        Console.ReadLine();

        return true;
    }
}
