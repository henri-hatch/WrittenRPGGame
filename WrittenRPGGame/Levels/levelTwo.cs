namespace WrittenRPGGame;

public class levelTwo : Interactions
{
    private static bool choiceOne;

    public static bool LevelTwoInteract(int choice)
    {
        switch (choice)
        {
            case 1:
                if (OneIsUsed)
                {
                    return Commands.Interact(2);
                    break;
                }
                else
                {
                    Console.WriteLine("You tested the object!");
                    OneIsUsed = true;
                    break;
                }
                
        }

        return false;
    }
}