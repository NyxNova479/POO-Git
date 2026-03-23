using Unity.Hierarchy;
using UnityEngine;

public class MotorCycle : Vehicle
{
    public float motorcycleLeanAngle;
    protected override void Move()
    {
        if (MoveInput > 0)
        {
            Speed += Acceleration * 1.2f * MoveInput * Time.deltaTime; // Les motos accélèrent plus vite
            // Logique spécifique à la moto
            ApplyMotorCycleLean();
        }
        else if (MoveInput < 0)
        {
            Speed -= BrakeForce * 0.8f * Mathf.Abs(MoveInput) * Time.deltaTime;
        }

        transform.Rotate(0, TurnInput * Handling * Speed * 0.15f * Time.deltaTime, 0);
    }

    private void ApplyMotorCycleLean()
    {
        // Simuler l'inclinaison d'une moto dans les virages
        float targetLean = -TurnInput * motorcycleLeanAngle;
        Vector3 currentRotation = transform.localEulerAngles;
        currentRotation.z = Mathf.LerpAngle(currentRotation.z, targetLean, Time.deltaTime * 2.0f);
        transform.localEulerAngles = currentRotation;
    }
}
