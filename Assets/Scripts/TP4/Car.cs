using UnityEngine;

public class Car : Vehicle
{
    private float carTraction;


    protected override void Move()
    {
        if (MoveInput > 0)
        {
            Speed += Acceleration * MoveInput * Time.deltaTime;
            // Logique spécifique à la voiture
            ApplyCarTraction();
        }
        else if (MoveInput < 0)
        {
            Speed -= BrakeForce * Mathf.Abs(MoveInput) * Time.deltaTime;
        }

        transform.Rotate(0, TurnInput * Handling * Speed * 0.05f * Time.deltaTime, 0);
    }

    private void ApplyCarTraction()
    {
        // Simuler la traction d'une voiture
        if (Physics.Raycast(transform.position, -transform.up, out RaycastHit hit, 1.0f))
        {
            float surfaceFactor = 1.0f;
            if (hit.collider.CompareTag("Dirt")) surfaceFactor = 0.7f;
            if (hit.collider.CompareTag("Ice")) surfaceFactor = 0.3f;
            Speed *= (1.0f - (1.0f - carTraction) * (1.0f - surfaceFactor));
        }
    }
}
