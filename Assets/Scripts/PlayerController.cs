using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    public float jumpForce = 10f;

    public Transform groundCheck;
    public LayerMask groundLayer;
    public float groundCheckRadius = 0.2f;

    private Rigidbody2D rb;
    private float horizontalInput;
    private bool isGrounded;

    private Animator animator;

    // Start se llama una vez al inicio
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update se llama una vez por frame (ideal para inputs)
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        FlipSprite();

        if (horizontalInput != 0) 
        { 
            animator.SetBool("isRunning", true); 
        } 
        
        else 
        { 
            animator.SetBool("isRunning", false); 
        } 

        
        void FlipSprite() 
        { 
            if (horizontalInput > 0) 
            { 
                transform.localScale = new Vector3(1, 1, 1); 
            } 
            else if (horizontalInput < 0) 
            { 
                transform.localScale = new Vector3(-1, 1, 1); 
            } 
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    // FixedUpdate se llama en un intervalo fijo (ideal para físicas)
    void FixedUpdate()
    { 
        isGrounded = Physics2D.OverlapCircle(
            groundCheck.position,
            groundCheckRadius,
            groundLayer
        );

        Debug.Log(isGrounded);

        // Mover personaje
        rb.linearVelocity = new Vector2(
            horizontalInput * moveSpeed,
            rb.linearVelocity.y
        );
    }

    // Funci�n para voltear el sprite del jugador
    void FlipSprite()
    {
        if (horizontalInput > 0) 
        { 
            transform.localScale = new Vector3(1, 1, 1); 
        } 
        
        else if (horizontalInput < 0) 
        { 
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    void OnDrawGizmosSelected()
{
    if (groundCheck != null)
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(
            groundCheck.position,
            groundCheckRadius
        );
    }
}
}