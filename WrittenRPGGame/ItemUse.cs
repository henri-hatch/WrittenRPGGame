namespace WrittenRPGGame;

public class ItemUse : Game
{
    
    // Adds a use method for every item to call from inventory.cs

    public static void Use(string name)
    {

        switch (name)
        {
            
            case "potion":
                Interactions.ActionText("You drink the potion");
                _player.CurrentHp = _player.CurrentHp + 50;
                if (_player.CurrentHp > _player.MaxHp)
                {

                    _player.CurrentHp = _player.MaxHp;
                }
                break;
        }
    }
}