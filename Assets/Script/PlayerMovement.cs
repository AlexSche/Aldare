using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float movSpeed;
    float speedX, speedY;
    public Rigidbody2D rb;

    private Vector2 moveDirection; 

    // Update is called once per frame
    void Update()
    {
        //Processing Inputs
        ProcessInputs();
    }

    void FixedUpdate()
    {
        //Physical Calculations 
        Move();

    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {
        rb.linearVelocity = new Vector2(moveDirection.x * movSpeed, moveDirection.y * movSpeed);
    }
}
