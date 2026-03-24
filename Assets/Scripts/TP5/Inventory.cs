using NUnit.Framework;
using System.Collections.Generic;

public class Inventory
{
    private List<Items> items = new List<Items>();
    private int itemCount = 0;
    
    public void AddItem(Items item)
    {
        if (itemCount < items.Count)
        {
            items[itemCount] = item;
            itemCount++;
        }
    }
    
    public void RemoveItem(int index)
    {
        if (index >= 0 && index < itemCount)
        {
            // Décaler tous les éléments
            for (int i = index; i < itemCount - 1; i++)
            {
                items[i] = items[i + 1];
            }
            items[itemCount - 1] = null;
            itemCount--;
        }
    }
    
    public float GetTotalWeight()
    {
        float totalWeight = 0;
        for (int i = 0; i < itemCount; i++)
        {
            totalWeight += items[i].Weight;
        }
        return totalWeight;
    }
}