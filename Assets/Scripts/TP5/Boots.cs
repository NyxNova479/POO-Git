using UnityEngine;

public class Boots : Armor
{
    public override void EquipArmor(Player player)
    {
        player.EquippedBoots = this;
    }

    public override void UseItem(Player player)
    {
        EquipArmor(player);
    }


}
