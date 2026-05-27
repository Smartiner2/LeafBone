using UnityEngine;

public class ItemEspecial : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameOverManager.instance.tieneItemEspecial = true;

            Debug.Log("Item especial conseguido");

            GameOverManager.instance.SendMessage("VerificarVictoria");

            Destroy(gameObject);
        }
    }
}
