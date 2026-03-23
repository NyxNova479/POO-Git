
//extends
using Unity.Burst.Intrinsics;
using UnityEngine;

public class ArmeMelee: Arme
{
    public override void Attaquer(Enemy enemy)
    {

        base.Attaquer(enemy);
        // J'attaque en mélée
    }
    private void OnCollisionStay(Collision collision)
    {
        Attaquer(collision.gameObject.GetComponent<Enemy>());
    }
}