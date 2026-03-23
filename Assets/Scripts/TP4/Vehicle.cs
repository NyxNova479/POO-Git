using UnityEngine;
using static VehicleController;

public abstract class Vehicle : MonoBehaviour
{

    private float speed;
    private float maxSpeed;
    private float acceleration;
    private float handling;
    private float brakeForce;

    float moveInput = Input.GetAxis("Vertical");
    float turnInput = Input.GetAxis("Horizontal");

    protected float Speed { get => speed; set => speed = value; }
    protected float MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
    protected float Acceleration { get => acceleration; set => acceleration = value; }
    protected float Handling { get => handling; set => handling = value; }
    protected float BrakeForce { get => brakeForce; set => brakeForce = value; }
    public float MoveInput { get => moveInput; set => moveInput = value; }
    public float TurnInput { get => turnInput; set => turnInput = value; }

    private void Update()
    {
        MoveInput = Input.GetAxis("Vertical");
        TurnInput = Input.GetAxis("Horizontal");

        Move();

        // Limiter la vitesse maximale
        speed = Mathf.Clamp(speed, 0, maxSpeed);

        // Déplacement
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    protected abstract void Move();


}
