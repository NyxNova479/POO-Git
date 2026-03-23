using UnityEngine;

public class Arme : MonoBehaviour,IDamager
{
    // Les propriétés de ma classe

    // Qu'est-ce qui caractérise une arme?
    // Nom, Degats
    private int id;
    private int degats;
    private float range;



    public int Id { get => id; set => id = value; }
    public int Degats { get => degats; set => degats = value; }
    public float Range { get => range; set => range = value; }



    public Arme()
    {
        Degats = 1;

    }
    public Arme(int id, int degats, float range)
    {
        this.Id = id;
        this.Degats = degats;
        this.Range = range;
    }



    // Le fonctionnement de ma classe

    // Que peut faire une arme?
    public void attaquer()
    {

    }
    public void faireDegat(IDamageable cible)
    {

    }
    public virtual void Attaquer(Enemy enemy)
    {
        // l'attaque de toutes les armes
        enemy.TakeDamage(Degats);
    }

}