using UnityEngine;

public abstract class Armor : Items, IEquipable
{

    // Propriétés spécifiques aux armures
    public int defense;
    public string armorType; // "Helmet", "Chest", "Boots", etc.



    public void beEquiped(IEquiper equiper)
    {
        EquipArmor();
    }

    public override void UseItem()
    {
        beEquiped(player);
    }

    public void EquipArmor()
    {
        if (armorType == "Helmet")
        {
            equippedHelmet = armor;
        }
        else if (armor.armorType == "Chest")
        {
            equippedChest = armor;
        }
        else if (armor.armorType == "Boots")
        {
            equippedBoots = armor;
        }
    }

}
