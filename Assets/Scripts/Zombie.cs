using UnityEngine;

namespace TP2_Heritage
{
    public class Zombie : Enemy
    {


        void Start() 
        {
            Health = 100;
            Damage = 10;
            Speed = 2f;
            DetectionRange = 10f;
        }
        

    }
}