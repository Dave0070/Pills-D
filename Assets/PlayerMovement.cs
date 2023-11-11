using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Standardowa prędkość poruszania się
    public float sprintMultiplier = 2f; // Mnożnik prędkości podczas sprintu

    void Update()
    {
        // Pobieranie wartości osi wejściowych (klawiszy) dla poruszania się
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        // Ustawianie wektora ruchu
        Vector3 movement = new Vector3(horizontalMovement, 0f, verticalMovement).normalized;

        // Sprawdzanie, czy naciśnięto klawisz Shift lub Ctrl
        bool isSprinting = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl);

        // Obliczanie prędkości poruszania się, uwzględniając sprint
        float currentSpeed = isSprinting ? moveSpeed * sprintMultiplier : moveSpeed;

        // Przesuwanie postaci
        transform.Translate(movement * currentSpeed * Time.deltaTime);
    }
}