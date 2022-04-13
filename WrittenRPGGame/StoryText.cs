namespace WrittenRPGGame;

public class StoryText : Game
{
    // This is for all story text and text blocks in general. Should have legible keywords for method names.
    // Return some sort of value at the end tell the game that this sect is over and to continue to the next section.
    // If there is some sort of choice involved, return an integer, otherwise just return true as a boolean.

    public void MainStory(int section)
    {
        
        switch (section) {
            
            case 1:

                Console.WriteLine("You wake up, head spinning and the edges of your vision blurry.\n" +
                                  "Your mouth is dry and your throat parched and something sticky clings to the side\n" +
                                  "of your face. Your wrists are held in place, bound to the stone wall behind you\n" +
                                  "by thick chains.");
                
                Console.Write("\n\nGive the command <look> a try! Type 'look'.");
                
                StoryBreak();
                break;
        }
    }

    public static void LookStory(int currentStage)
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

    public void InteractStory(int currentStage, int choice)
    {
        
        // This is gonna be a bit messy, a lot of nested switch statements. The outlying switch statements decide
        // and get the input for the current stage, and the inside or nested switch statements will determine which
        // option you chose in said stage.

        Console.WriteLine();
        switch (currentStage)
        {
            
            case 1:
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Chains");
                        break; 
                    case 2:
                        Console.WriteLine("Stones");
                        break;
                    case 3:
                        Console.WriteLine("Door");
                        break;
                    case 4:
                        Console.WriteLine("Window");
                        break;
                    case 5:
                        Console.WriteLine("Imp");
                        break;
                }

                break;
        }
    }
}
