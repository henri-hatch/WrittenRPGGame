namespace WrittenRPGGame;

public class Player
{
    // This defines the Player and sets properties.
    // Could be added to. May add other modifiers such as Speed, Agility, or Dexterity for maybe a change to dodge.
    // Just to start off, keep it simple and do some base modifiers, but maybe broaden out so the player can build
    // whatever they want.

    public int CurrentHp { get; set; }
    public int MaxHp { get; set; }
    public int Gold { get; set; }
    public int Exp { get; set; }
    public int Level { get; set; }
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Dexterity { get; set; }
    public int Armor { get; set; }
    public int Blessing { get; set; }
    public bool IsChained { get; set; }
}
