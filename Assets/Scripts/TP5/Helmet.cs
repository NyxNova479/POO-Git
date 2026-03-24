using UnityEngine;

public class Helmet : Armor
{
    public override void EquipArmor(Player player)
    {
        player.EquippedHelmet = this;
    }

    public override void UseItem(Player player)
    {
        EquipArmor(player);
    }

}
