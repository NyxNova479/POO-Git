using UnityEngine;

public class Weapons : Items, IUsable
{

    // Propriétés spécifiques aux armes
    private int damage;
    private float range;

    public int Damage { get => damage; set => damage = value; }
    public float Range { get => range; set => range = value; }



    public override void UseItem(Player player)
    {
        beUsed(player);
    }
    public void beUsed(Player player)
    {
        Attack();
    }

    private void Attack()
    {
        // Logique d'attaque avec l'arme équipée
        System.Console.WriteLine($"{name} attaque pour {Damage} points de dégâts!");
    }


}
