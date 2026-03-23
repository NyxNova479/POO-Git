using UnityEngine;

public class Arme : MonoBehaviour
{
    // Les propriétés de ma classe

    // Qu'est-ce qui caractérise une arme?
    // Nom, Degats
    private string nom;
    private int degats;

    public string Nom { get => nom; set => nom = value; }
    public int Degats { get => degats; set => degats = value; }

    public string getNom()
    {
        return Nom;
    }

    public int getDegats()
    {
        return Degats;
    }

    public void setNom(string valeur)
    {
        Nom = valeur;
        
    }
    public void setDegat(int valeur)
    {
        Degats = valeur;
        
    }

    public Arme()
    {
        Degats = 5;
        Nom = "Bâton";
    }
    public Arme(int degatsDeBase)
    {
        Degats = degatsDeBase;
        Nom = "Bâton";
    }
    public Arme(string nomDeBase)
    {
        Degats = 5;
        Nom = nomDeBase;
    }
    public Arme(string nomDeBase, int degatsDeBase)
    {
        Degats = degatsDeBase;
        Nom = nomDeBase;
    }

    // Le fonctionnement de ma classe

    // Que peut faire une arme?
    public virtual void Attaquer(Enemy enemy)
    {
        // l'attaque de toutes les armes
        enemy.TakeDamage(degats);
    }

}