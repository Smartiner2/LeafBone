using UnityEngine;

public class Diamante : MonoBehaviour
{
    public int puntos = 50;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            GameOverManager.instance.SumarDiamante(puntos);

            Destroy(gameObject);
        }
    }
}
