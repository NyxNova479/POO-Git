using UnityEngine;

namespace TP2_Heritage
{
    public class Skeleton : Enemy
    {
        
        
        void Start() 
        {
            Health = 80;
            Damage = 15;
            Speed = 3f;
            DetectionRange = 12f;
        }
        

    }
}