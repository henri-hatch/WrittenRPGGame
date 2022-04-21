namespace WrittenRPGGame;

public class Item
{
    public string Name;
    public string Desc;
    public int Quantity;

    public Item(string name, string desc, int quantity)
    {

        Name = name;
        Desc = desc;
        Quantity = quantity;
    }
}
