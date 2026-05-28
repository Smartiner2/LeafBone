using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 10f;

    private Rigidbody2D rb;

    // Cantidad máxima de saltos
    public int maxJumps = 2;

    // Saltos restantes
    private int jumpsLeft;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Empieza con los 2 saltos disponibles
        jumpsLeft = maxJumps;
    }

    void Update()
    {
        // Cuando toca el suelo, reinicia los saltos
        if (CheckGround.isGrounded)
        {
            jumpsLeft = maxJumps;
        }

        // Si presiona espacio y todavía tiene saltos
        if (Input.GetButtonDown("Jump") && jumpsLeft > 0)
        {
            // Aplica salto
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);

            // Resta un salto
            jumpsLeft--;
        }
    }
}
