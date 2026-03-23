using UnityEngine;

public class Boss : Enemy
{
    private int specialPower;
    private float reducingFactor;
    public Boss(int pouvoirSpecial, float reducing) : base()
    {
        specialPower = pouvoirSpecial;
        reducingFactor = reducing;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Health = 500;
        Damage = 30;
        Speed = 4f;
        DetectionRange = 10f;
        specialPower = 50;
        reducingFactor = 0.5f;
    }

    public override void TakeDamage(int amount)
    {
        Health -= (int)(amount/reducingFactor);
        if (Health <= 0)
        {
            Die();
        }
    }


    public override void Die()
    {
        Debug.Log($"De son dernier souffle, le boss explose et inflige {specialPower} points de degats.");
        base.Die();
    }


}
