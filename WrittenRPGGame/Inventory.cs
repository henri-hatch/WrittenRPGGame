namespace WrittenRPGGame;

public class Inventory : Game
{

    public List<Item> playerInventory = new List<Item>();

    public void addItem(string name, string desc, int quantity)
    {

        bool containsItem = playerInventory.Any(item => item.Name == name);

        if (containsItem == false)
        {
            
            playerInventory.Add(new Item(name, desc, quantity));
        }
        else
        {

            foreach (Item items in playerInventory)
            {

                if (items.Name == name)
                {

                    items.Quantity = items.Quantity + 1;
                }
            }
        }
    }
}