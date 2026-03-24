using UnityEngine;

public class Potion : Items, IUsable
{

    // Propriétés spécifiques aux potions
    private int healthRestored;
    private float duration;




    public void beUsed(IUser user)
    {

        RestoreHealth(user.hea);
    }

    public void RestoreHealth(int health, int maxHealth)
    {
        while (duration > 0)
        {
            health = System.Math.Min(health + healthRestored, maxHealth);
            duration--;
        }
        System.Console.WriteLine($"{name} restaure {healthRestored} points de vie!");
    }

    public override void UseItem(Player player)
    {
        beUsed(player);
    }
}
