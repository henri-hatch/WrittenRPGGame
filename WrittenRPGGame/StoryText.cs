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
}
