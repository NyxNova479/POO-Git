using UnityEngine;

public class Arme : ItemRamassable,IDamager
{
    // Les propriétés de ma classe

    // Qu'est-ce qui caractérise une arme?

    private int id;
    private int degats;
    private float range;



    public int Id { get => id; set => id = value; }
    public int Degats { get => degats; set => degats = value; }
    public float Range { get => range; set => range = value; }


    public override void seFaireRamasser(IRamasser ramasser)
    {
        base.seFaireRamasser (ramasser);
        Debug.Log(this + " : Equipe toi de moi " + ramasser);
        ramasser.equiper(this);
    }

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
    public virtual void attaquer()
    {
        Debug.Log("J'attaque avec une arme");
    }
    public void faireDegat(IDamageable cible)
    {

    }


}