using UnityEngine;

public abstract class Armor : Items, IEquipable
{

    // Propriétés spécifiques aux armures
    private int defense;
    private string armorType; // "Helmet", "Chest", "Boots", etc.

    public int Defense { get => defense; set => defense = value; }

    public void beEquiped(Player player)
    {
        EquipArmor(player);
    }

    public override void UseItem(Player player)
    {
        beEquiped(player);
    }

    public abstract void EquipArmor(Player player);

}
