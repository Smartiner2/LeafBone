using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed=5f;
    public float jumpSpeed=7f;
    private Rigidbody2D rb;
    private float horizontalInput;

    // Start se llama una vez al inicio
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update se llama una vez por frame (ideal para inputs)
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

    }

    // FixedUpdate se llama en un intervalo fijo (ideal para físicas)
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);

    }

    // Funci�n para voltear el sprite del jugador
    void FlipSprite()
    {
        
    }

    // (Opcional) Dibuja el círculo de groundCheck en el editor para que puedas verlo
    void OnDrawGizmosSelected()
    {
        
    }
}