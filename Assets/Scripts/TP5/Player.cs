using UnityEngine;
public class Player : MonoBehaviour
{
    [SerializeField]private string playerName;
    [SerializeField]private int health;
    [SerializeField]private int maxHealth;


    IEquipable equippedHelmet;
    IEquipable equippedChest;
    IEquipable equippedBoots;

    public IEquipable EquippedHelmet { get => equippedHelmet; set => equippedHelmet = value; }
    public IEquipable EquippedChest { get => equippedChest; set => equippedChest = value; }
    public IEquipable EquippedBoots { get => equippedBoots; set => equippedBoots = value; }

    public void Attack(IUsable weapon)
    {
        weapon.beUsed(this); 
    }
    
    public void RestoreHealth(IUsable potion)
    {

        potion.beUsed(this);
    }
    
    private void EquipArmor(IEquipable armor)
    {
        armor.beEquiped(this);
    }

}