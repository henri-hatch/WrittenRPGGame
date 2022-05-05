namespace WrittenRPGGame;

/* IDs:
 * 1 - Test
 * 2 - 
 * 3 - 
 * 4 - 
 * 5 - 
 */
public class EnemyFactory
{

    public static List<Enemy> enemyList = new List<Enemy>();

    public static void AddEnemy(int id, string name, int currentHp, int maxHp, int level, int strength, int agility, int dexterity, int armor)
    {

        bool containsEnemy = enemyList.Any(item => item.Id == id);
        
        if (containsEnemy == false)
        {
            
            enemyList.Add(new Enemy(id, name, currentHp, maxHp, level, strength, agility, dexterity, armor));
        }
        else
        {
            
            Console.WriteLine("Enemy already exists in list!");
        }
    }

    public void InstantiateEnemies()
    {
        
        AddEnemy(1, "Test Enemy", 100, 100, 1, 1, 1, 1, 5);
    }
}