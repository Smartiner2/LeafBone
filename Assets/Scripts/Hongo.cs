using UnityEngine;

public class Hongo : MonoBehaviour
{
    public int puntos = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            GameOverManager.instance.SumarHongo(puntos);

            Destroy(gameObject);
        }
    }
}
