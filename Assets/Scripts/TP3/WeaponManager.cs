using UnityEngine;

namespace TP3_Polymorphisme
{
    public class WeaponManager : MonoBehaviour
    {
        [SerializeField] private Weapon currentWeapon;
        
        public void Attack()
        {
            if (currentWeapon != null) return;
            currentWeapon.Attack();
        }

        public void SwitchWeapon(Weapon weaponName)
        {
            currentWeapon.gameObject.SetActive(false);
            currentWeapon = weaponName;
            currentWeapon.gameObject.SetActive(true);

        }
    }
}