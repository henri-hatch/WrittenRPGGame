namespace WrittenRPGGame;

public class Interactables
{
    // This will contain all interactables in each stage when looking. Each item will be contained in a list
    // and can be looped through to list and interact with each item. Some can be picked up, others cannot.

    public static List<string> areaOne = new List<string>();
    
    public void SetInteractLists()
    {

        areaOne.Add("1. Chains");
        areaOne.Add("2. Loose Stones");
        areaOne.Add("3. The Door");
        areaOne.Add("4. The Window");
        areaOne.Add("5. Heap of Cloth on the Ground");
    }

    public static int Interact(int currentStory)
    {

        int choice = 0;

        Console.WriteLine("Enter an option using the number before each option.");
        switch (currentStory)
        {
            
            case 1:
                for (int i = 0; i < areaOne.Count; i++)
                {
                    
                    Console.WriteLine(areaOne[i]);
                }
                
                Console.Write("\nEnter your choice >> ");
                choice = Convert.ToInt32(Console.ReadLine());

                break;
        }

        return choice;
    }
}
