using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 1f; 
    private Rigidbody2D rb; 
    


void Start() 
{ 
    rb = GetComponent<Rigidbody2D>(); 
} 

void Update() 
{ 
    if (Input.GetButtonDown("Jump") && CheckGround.isGrounded) 
    { 
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce); 
    } 

}



}
