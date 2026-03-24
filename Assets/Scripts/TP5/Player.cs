using UnityEngine;
public class Player : MonoBehaviour
{
    private string playerName;
    private int health;
    private int maxHealth;


    private IEquipable equippedHelmet;
    private IEquipable equippedChest;
    private IEquipable equippedBoots;

    public IEquipable EquippedHelmet { get => equippedHelmet; set => equippedHelmet = value; }
    public IEquipable EquippedChest { get => equippedChest; set => equippedChest = value; }
    public IEquipable EquippedBoots { get => equippedBoots; set => equippedBoots = value; }
    public int Health { get => health; set => health = value; }
    public int MaxHealth { get => maxHealth; set => maxHealth = value; }

    private void Attack(IUsable weapon)
    {
        weapon.beUsed(this); 
    }
    
    private void RestoreHealth(IUsable potion)
    {

        potion.beUsed(this);
    }
    
    private void EquipArmor(IEquipable armor)
    {
        armor.beEquiped(this);
    }

}