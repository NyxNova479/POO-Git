using UnityEngine;

public class Joueur : MonoBehaviour, IDamageable, IRamasser
{

    private int id;
    private int vie;
    private int vitesseCourse;
    private Arme armeEquipee;

    public int Id { get => id; set => id = value; }
    public int Vie { get => vie; set => vie = value; }
    public int VitesseCourse { get => vitesseCourse; set => vitesseCourse = value; }

    public void seDeplacer()
    {
        transform.Translate(Vector3.forward * 2 * Time.deltaTime);
    }

    public void attaquer()
    {
        if (armeEquipee == null) return;
        armeEquipee.attaquer();
    }
    public void prendreDegat(int degats)
    {
        Debug.Log("aïe - " + degats);
    }

    public void ramasser(IRamassable item)
    {
        Debug.Log("Joueur ramsse " + item);
        item.seFaireRamasser(this);
    }
    public void equiper(Arme arme)
    {
        armeEquipee = arme;
        Debug.Log("Le joueur " + this + "a equipe" + armeEquipee);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // La vitesse peut être modifiée à n'importe quelle valeur
        seDeplacer();
        if (Input.GetKeyDown(KeyCode.E))
        {
            attaquer();
        }
    }


    public Joueur(int id, int vie, int vitesseCourse)
    {
        this.Id = id;
        this.Vie = vie;
        this.VitesseCourse = vitesseCourse;
    }
}
