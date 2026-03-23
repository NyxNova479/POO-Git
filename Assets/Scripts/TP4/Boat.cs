using UnityEngine;

public class Boat : Vehicle
{
    public float boatBuoyancy;



    protected override void Move()
    {

        if (MoveInput > 0)
        {
            Speed += Acceleration * 0.8f * MoveInput * Time.deltaTime;
            // Logique spécifique à l'avion
            ApplyBoatBuoyancy();
        }
        else if (MoveInput < 0)
        {
            Speed -= BrakeForce * 0.6f * Mathf.Abs(MoveInput) * Time.deltaTime;
        }

        transform.Rotate(0, TurnInput * Handling * Speed * 0.05f * Time.deltaTime, 0);
    }

    private void ApplyBoatBuoyancy()
    {
        // Simuler la flottabilité d'un bateau
        if (Physics.Raycast(transform.position, -transform.up, out RaycastHit hit, 2.0f))
        {
            if (hit.collider.CompareTag("Water"))
            {
                float desiredHeight = hit.point.y + boatBuoyancy;
                Vector3 pos = transform.position;
                pos.y = Mathf.Lerp(pos.y, desiredHeight, Time.deltaTime * 2.0f);
                transform.position = pos;
            }
        }
    }
}
