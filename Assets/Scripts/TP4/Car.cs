using UnityEngine;

public class Car : Vehicule
{
    private float carTraction;
    protected override void ApplyTraction()
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
