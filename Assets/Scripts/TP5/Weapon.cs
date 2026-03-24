using UnityEngine;

public class Weapons : Items, IUsable
{

    // Propriétés spécifiques aux armes
    public int damage;
    public float range;



    public void beUsed(IUser user)
    {
        Attack();
    }

    public override void UseItem(IUser user)
    {
        beUsed(user);
    }

    private void Attack()
    {
        // Logique d'attaque avec l'arme équipée
        System.Console.WriteLine($"{name} attaque pour {damage} points de dégâts!");
    }


}
