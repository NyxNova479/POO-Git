using UnityEngine;

public class Joueur : MonoBehaviour, IDamageable
{

    private int id;
    private int vie;
    private int vitesseCourse;

    public void seDeplacer()
    {

    }

    public void attaquer()
    {

    }

    public void ramasser()
    {

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void prendreDegat(int degats)
    {
        Debug.Log("aïe - " + degats);
    }

    public Joueur(int id, int vie, int vitesseCourse)
    {
        this.id = id;
        this.vie = vie;
        this.vitesseCourse = vitesseCourse;
    }
}
