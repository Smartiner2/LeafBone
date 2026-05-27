using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float speed = 3f;

    // PANEL DE MUERTE
    public GameObject defeatScreen;

    private Rigidbody2D rb;
    private Transform player;

    private bool chasingPlayer = false;

    // Para voltear el sprite
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        if (chasingPlayer && player != null)
        {
            float direction =
                player.position.x - transform.position.x;

            // Movimiento horizontal
            rb.linearVelocity = new Vector2(
                Mathf.Sign(direction) * speed,
                rb.linearVelocity.y
            );

            // VOLTEAR ENEMIGO
            if (direction > 0)
            {
                spriteRenderer.flipX = false;
            }
            else if (direction < 0)
            {
                spriteRenderer.flipX = true;
            }
        }
        else
        {
            rb.linearVelocity = new Vector2(
                0,
                rb.linearVelocity.y
            );
        }
    }

    // DETECTAR JUGADOR
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player = other.transform;

            chasingPlayer = true;
        }
    }

    // DEJAR DE PERSEGUIR
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            chasingPlayer = false;
        }
    }

    // MATAR JUGADOR
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);

            Debug.Log("GAME OVER");

            // MOSTRAR PANEL
            defeatScreen.SetActive(true);

            // PAUSAR JUEGO
            Time.timeScale = 0f;
        }
    }
}
