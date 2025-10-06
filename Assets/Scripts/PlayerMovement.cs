using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float speed = 10;
    InputAction playerMoveAction;

    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        playerMoveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 playerMovement = new Vector2(playerMoveAction.ReadValue<Vector2>().x, 0) * speed;
        rb.AddForce(playerMovement); 
    }
}
