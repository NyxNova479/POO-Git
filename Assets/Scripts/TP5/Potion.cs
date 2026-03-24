using UnityEngine;

public class Potion : Items, IUsable
{

    // Propriétés spécifiques aux potions
    private int healthRestored;
    private float duration;




    public void beUsed(Player user)
    {

        RestoreHealth(user.Health, user.MaxHealth);
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

    public override void UseItem(Player user)
    {
        beUsed(user);
    }
}
