using UnityEngine;

public class Trampas : MonoBehaviour
{
    public GameOverManager gameOverManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);

            gameOverManager.MostrarPantallaMuerte();
        }
    }



}
