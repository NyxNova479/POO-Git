using UnityEngine;

public class Axe : Weapon
{
    public override void Attack()
    {

        // Logique d'attaque à l'épée
        Debug.Log("Swinging axe");
        // Animation, effets sonores, etc.

        // Détection des ennemis à proximité
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 4f);
        foreach (var hitCollider in hitColliders)
        {
            Enemy enemy = hitCollider.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(20);
            }
        }
    }
}
