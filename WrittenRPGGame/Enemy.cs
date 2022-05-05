using System.Runtime.InteropServices.ComTypes;

namespace WrittenRPGGame;

public class Enemy
{
    public int Id;
    public string Name;
    
    // Stats
    public int CurrentHp;
    public int MaxHp;
    public int Level;
    public int Strength;
    public int Agility;
    public int Dexterity;
    public int Armor;

    public Enemy(int id, string name, int currentHp, int maxHp, int level, int strength, int agility, int dexterity, int armor)
    {

        Id = id;
        Name = name;
        CurrentHp = currentHp;
        MaxHp = maxHp;
        Level = level;
        Strength = strength;
        Agility = agility;
        Dexterity = dexterity;
        Armor = armor;
    }
}