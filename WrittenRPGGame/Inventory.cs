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

    public static void removeItem(string name, int quantity)
    {

        Item item = playerInventory.SingleOrDefault(x => x.Name == name);

        if (item != null)
        {

            for (int i = 1; i <= quantity; i++)
            {

                item.Quantity = item.Quantity - 1;
                if (item.Quantity == 0)
                {
                    
                    Console.WriteLine("Removed item!");
                    playerInventory.Remove(item);
                    break;
                }
            }
            
            Console.WriteLine("Removed " + quantity + " from " + name);
        }

        else
        {
            
            Console.WriteLine("This item does not exist in your inventory!");
            return;
        }
    }
}