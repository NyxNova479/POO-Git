using UnityEngine;

public class Chest : Armor
{
    public override void EquipArmor(Player player)
    {
        player.EquippedChest = this;
    }

    public override void UseItem(Player player)
    {
        EquipArmor(player);
    }


}
