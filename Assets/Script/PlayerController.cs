using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float movSpeed;
    public Camera sceneCamera;
    public Rigidbody2D rb;
    public Weapon weapon;

    private Vector2 moveDirection; 
    private Vector2 mousePosition;

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

        if(Input.GetMouseButtonDown(0))
        {
            weapon.Fire();
        }
        moveDirection = new Vector2(moveX, moveY).normalized;
        mousePosition = sceneCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    void Move()
    {
        rb.linearVelocity = new Vector2(moveDirection.x * movSpeed, moveDirection.y * movSpeed);

        //rotate Player to follow the mouse
        Vector2 aimdirection =  mousePosition - rb.position;
        // Calculate the angle
        float aimAngle = Mathf.Atan2(aimdirection.y, aimdirection.x) * Mathf.Rad2Deg- 90f;
        rb.rotation = aimAngle; 
    }
}
