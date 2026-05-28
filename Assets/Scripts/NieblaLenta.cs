using UnityEngine;

public class NieblaLenta : MonoBehaviour
{
    // Velocidad dentro de la niebla
    public float velocidadReducida = 2f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player =
                other.GetComponent<PlayerController>();

            if (player != null)
            {
                player.ReducirVelocidad(
                    velocidadReducida
                );

                Debug.Log("Jugador ralentizado");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player =
                other.GetComponent<PlayerController>();

            if (player != null)
            {
                player.RestaurarVelocidad();

                Debug.Log("Velocidad restaurada");
            }
        }
    }
}
