

using System.Numerics;
using UnityEngine;

public class ArmeDistance : Arme
{
    private float shootRange;
    
    public ArmeDistance(string nomDeBase, int degatsDeBase, float shootDistance) : base(nomDeBase, degatsDeBase)
    {
        this.shootRange = shootDistance;
    } 
    public override void Attaquer(Enemy enemy)
    {
        // J'attaque à distance
        if (enemy.transform.position.z < shootRange || enemy.transform.position.z > shootRange) return;
        base.Attaquer(enemy);
    }
}