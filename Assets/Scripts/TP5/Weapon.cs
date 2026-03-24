using UnityEngine;

public class Weapons : Items, IUsable
{

    // Propriétés spécifiques aux armes
    private int damage;
    private float range;

    public int Damage { get => damage; set => damage = value; }
    public float Range { get => range; set => range = value; }

    public void beUsed(IUser user)
    {
        Attack();
    }

    public override void UseItem(Player user)
    {
        beUsed(user);
    }

    private void Attack()
    {
        // Logique d'attaque avec l'arme équipée
        System.Console.WriteLine($"{name} attaque pour {Damage} points de dégâts!");
    }


}
