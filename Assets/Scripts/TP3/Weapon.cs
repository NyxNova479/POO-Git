using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    private int id;
    private string weaponName;

    public Weapon()
    {
        this.id = 0;
        this.weaponName = "Fists";
    }
    protected Weapon(int id, string weaponName)
    {
        this.id = id;
        this.weaponName = weaponName;
    }

    public virtual void Attack()
    {
        Debug.Log("I attack");
    }
  


}
