

using TP2_Heritage;
using TP3_Polymorphisme;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField]protected int health;
    [SerializeField]protected int damage;
    [SerializeField]protected float speed;
    [SerializeField]protected float detectionRange;
    [SerializeField]protected Transform player;

    protected int Health { get => health; set => health = value; }
    protected int Damage { get => damage; set => damage = value; }
    protected float Speed { get => speed; set => speed = value; }
    protected float DetectionRange { get => detectionRange; set => detectionRange = value; }

    public Enemy()
    {
        this.Health = health;
        this.Damage = damage;
        this.Speed = speed;
        this.DetectionRange = detectionRange;
            
    }

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) < DetectionRange)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * Speed * Time.deltaTime;
        }
    }

    public virtual void TakeDamage(int amount)
    {
        Health -= amount;
        if (Health <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerCharacter player = collision.gameObject.GetComponent<PlayerCharacter>();
            if (player != null)
            {
                player.TakeDamage(Damage);
            }
        }
    }
}