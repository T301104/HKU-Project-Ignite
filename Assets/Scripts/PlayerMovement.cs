using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jumpStrength = 10;
    [SerializeField] private float speed = 10;
    InputAction playerMoveAction;
    InputAction jumpAction;


    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        playerMoveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (jumpAction.IsPressed())
        {
            rb.AddForce(Vector3.up * jumpStrength);
        }
        Vector2 playerMovement = new Vector2(playerMoveAction.ReadValue<Vector2>().x, 0) * speed;
        rb.AddForce(playerMovement); 
        
    }
}
