using UnityEngine;

namespace TP1_Encapsulation
{
    public class PlayerCharacter : MonoBehaviour
    {
        // Toutes les données sont publiques et peuvent être modifiées n'importe où
        [SerializeField]private string playerName;
        [SerializeField]private int health;
        [SerializeField]private int maxHealth;
        [SerializeField]private float moveSpeed;
        [SerializeField]private int gold;
        private bool isInvincible;

        public bool IsInvincible { get => isInvincible; set => isInvincible = value; }

        public int getHealth()
        {
            if (health < 0 || health > maxHealth) Debug.Log("La santé n'est pas acceptable");
            return health;
        }
        public float getMoveSpeed()
        {
            if (moveSpeed < 0 || moveSpeed > 20) Debug.Log("La vitesse de déplacement n'est pas acceptable");
            return moveSpeed;
        }

        public void setHealth(int valeur)
        {
            health = valeur;
            if (health < 0) health = 0;
            else if (health > maxHealth) health = maxHealth;
        }
        public void setSpeed(float valeur)
        {
            moveSpeed = valeur;
            if (moveSpeed < 0) moveSpeed = 0;
            else if (moveSpeed > 20) moveSpeed = 20;
            
        }
        public int getGold()
        {
            return gold;
        }

        public void setGold(int valeur)
        {
            gold = valeur;
            if(gold < 0) gold = 0;
        }

        void Update()
        {
            // Le personnage peut avoir une santé négative car rien ne l'empêche
            if (getHealth() <= 0)
            {
                Debug.Log("Player is dead");
            }

            // La vitesse peut être modifiée à n'importe quelle valeur
            transform.Translate(Vector3.forward * getMoveSpeed() * Time.deltaTime);
        }

        public void GainGold(int amount)
        {
            int currentGold = getGold();
            setGold(currentGold + amount);
        }
        public void SpendGold(int amount)
        {
            int currentGold = getGold();
            setGold(currentGold - amount);
        }

        public void Invicibility()
        {
            int duration = 20;
            if (IsInvincible)
            {
                while (duration < 0)
                {
                    duration--;
                }
                IsInvincible = false;
            }

        }

        // Méthode nécessaire pour les autres TPs, mais mal implémentée
        public void TakeDamage(int amount)
        {
            if (IsInvincible)
            {
                return;
            }
            int currenthealth = getHealth();
            setHealth(currenthealth - amount);
        }
    }
}