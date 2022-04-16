namespace WrittenRPGGame;

public class ObtainableItem
{
    
    public int ID { get; set; }
    public string Name { get; set; }
    public int MaxStackQuantity { get; set; }

    protected ObtainableItem()
    {

        MaxStackQuantity = 1;
    }
}
