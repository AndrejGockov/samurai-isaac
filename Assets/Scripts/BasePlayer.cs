using UnityEngine;

public class BasePlayer : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    private Vector2 moveInput;

    [SerializeField]
    private float movementSpeed = 7.5f;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        rigidBody2D.gravityScale = 0f;
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (UserInput.instance == null) 
            return;
        
        moveInput = UserInput.instance.moveInput;
        rigidBody2D.linearVelocity = moveInput * movementSpeed;
    }
}
