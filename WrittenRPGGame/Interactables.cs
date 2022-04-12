namespace WrittenRPGGame;

public class Interactables
{
    // This will contain all interactables in each stage when looking. Each item will be contained in a list
    // and can be looped through to list and interact with each item. Some can be picked up, others cannot.

    public List<string> areaOne = new List<string>();
    
    public void SetInteractLists()
    {

        areaOne.Add("1. Chains");
        areaOne.Add("2. Loose Stones");
        areaOne.Add("3. The Door");
        areaOne.Add("4. The Window");
        areaOne.Add("5. Heap of Cloth on the Ground");
    }

    public static void Interact(int currentStory)
    {
        
        
    }
}