namespace WrittenRPGGame;

public class Inventory : Game
{

    public static void addItem(string name, string desc, int quantity)
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