using UnityEngine;

public abstract class Items : MonoBehaviour
{
    private string itName;
    private string description;
    private float weight;
    private int value;


    public string ItName { get => itName; set => itName = value; }
    public string Description { get => description; set => description = value; }
    public float Weight { get => weight; set => weight = value; }
    public int Value { get => value; set => this.value = value; }

    protected Items()
    {
        this.itName = "Pièce rouillé";
        this.description = "Une vielle pièce rouillé ayant perdu sa valeur";
        this.weight = 2;
        this.value = 3;

    }

    protected Items(string itName, string description, float weight, int value)
    {
        this.itName = itName;
        this.description = description;
        this.weight = weight;
        this.value = value;
    }
    public abstract void UseItem(Player player);
}