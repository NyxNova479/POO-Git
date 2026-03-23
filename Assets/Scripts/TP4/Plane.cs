using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Plane : Vehicle
{

    public float airplaneLift;

    protected override void Move()
    {


        if(MoveInput > 0)
        {
            Speed += Acceleration * 0.8f * MoveInput * Time.deltaTime;
            // Logique spécifique à l'avion
            ApplyAirPlaneLift();
        }

        else if(MoveInput < 0)
        {
            Speed -= BrakeForce * 0.4f * Mathf.Abs(MoveInput) * Time.deltaTime;
        }

        transform.Rotate(TurnInput * Handling * 0.5f * Time.deltaTime,
                MoveInput * Handling * 0.3f * Time.deltaTime,
                -TurnInput * Handling * Time.deltaTime);
    }

    private void ApplyAirPlaneLift()
    {
        // Simuler la portance d'un avion
        if (Speed > MaxSpeed * 0.3f)
        {
            float liftForce = airplaneLift * (Speed / MaxSpeed);
            transform.Translate(Vector3.up * liftForce * Time.deltaTime, Space.World);
        }
    }
}
