using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    private string currentWeapon;

    protected string CurrentWeapon { get => currentWeapon; set => currentWeapon = value; }

    public virtual void Attack()
    {
        Debug.Log("j'attaque");
    }

    public void SwitchWeapon(string weaponName)
    {
        CurrentWeapon = weaponName;
    }
}
