using Unity.Mathematics;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jumpStrength = 10;
    [SerializeField] private float speed = 10;
    [SerializeField] private float friction = 0.4f;
    [SerializeField] private Vector3 boostPower;
    int lookingRight = 1;
    Collider coll;
    InputAction playerMoveAction;
    InputAction jumpAction;


    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        playerMoveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
        coll = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {


        Vector2 playerMovement = new Vector2(playerMoveAction.ReadValue<Vector2>().x, 0) * speed * Time.deltaTime;
        if (playerMoveAction.ReadValue<Vector2>().x < 0 && lookingRight == 1)
        {
            lookingRight = -1;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        if (playerMoveAction.ReadValue<Vector2>().x > 0 && lookingRight == -1)
        {
            lookingRight = 1;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        
        rb.AddForce(playerMovement);

        if (playerMovement != Vector2.zero)
        {
            coll.material.dynamicFriction = 0;
        }
        else
        {
            coll.material.dynamicFriction = friction;
        }

        //jump if on ground
        if (jumpAction.WasPressedThisFrame() && IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpStrength);
        }

        //if activated boost into the direction player is moving if a monkey can boost
        if (Input.GetKeyDown(KeyCode.Mouse1) && MonkeyManager.Instance.usableMonkeys > 0)
        {
            MonkeyManager.Instance.usableMonkeys--;

            rb.AddForce(new (boostPower.x * lookingRight, boostPower.y));
        }

    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 0.5f);
    }

}
