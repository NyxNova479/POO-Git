using UnityEngine;
public class Player : IUser, IEquiper
{
    [SerializeField]private string name;
    [SerializeField]private int health;
    [SerializeField]private int maxHealth;
    
    // L'inventaire est directement intégré dans la classe Player
    private Inventory inventory = new Inventory();
    
    // Des références directes aux objets équipés
    private IUsable equippedWeapon;
    private IEquipable equippedHelmet;
    private IEquipable equippedChest;
    private IEquipable equippedBoots;

    public string Name { get => name; set => name = value; }
    public int Health { get => health; set => health = value; }
    public int MaxHealth { get => maxHealth; set => maxHealth = value; }
    public IUsable EquippedWeapon { get => equippedWeapon; set => equippedWeapon = value; }
    public IEquipable EquippedHelmet { get => equippedHelmet; set => equippedHelmet = value; }
    public IEquipable EquippedChest { get => equippedChest; set => equippedChest = value; }
    public IEquipable EquippedBoots { get => equippedBoots; set => equippedBoots = value; }

    public void Attack()
    {
        EquippedWeapon.beUsed(this); 
    }
    
    public void RestoreHealth(int amount)
    {
        Health = System.Math.Min(Health + amount, MaxHealth);
        System.Console.WriteLine($"{Name} restaure {amount} points de vie!");
    }
    
    public void EquipArmor(IEquipable armor)
    {
        armor.beEquiped(this);
    }

    public void use()
    {
        throw new System.NotImplementedException();
    }

    public void equip()
    {
        return;
    }
}