using UnityEngine;

public abstract class Vehicule : MonoBehaviour
{

    private float speed;
    private float maxSpeed;
    private float acceleration;
    private float handling;
    private float brakeForce;

    protected float Speed { get => speed; set => speed = value; }
    protected float MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
    protected float Acceleration { get => acceleration; set => acceleration = value; }
    protected float Handling { get => handling; set => handling = value; }
    protected float BrakeForce { get => brakeForce; set => brakeForce = value; }

    protected abstract void ApplyTraction();

}
