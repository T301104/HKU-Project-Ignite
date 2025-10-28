using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jumpStrength = 10;
    [SerializeField] private float speed = 10;
    [SerializeField] private float friction = 0.4f;
    Collider coll;
    bool frictionZero = false;
    InputAction playerMoveAction;
    InputAction jumpAction;
    NpcMonkey npcMonkey;


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
        if (jumpAction.WasPressedThisFrame())
        {
            rb.AddForce(Vector3.up * jumpStrength);
        }
        Vector2 playerMovement = new Vector2(playerMoveAction.ReadValue<Vector2>().x, 0) * speed *Time.deltaTime;
        rb.AddForce(playerMovement);

        if (playerMovement != Vector2.zero)
        {
            frictionZero = true;
            coll.material.dynamicFriction = 0;
        }
        else
        {
            coll.material.dynamicFriction = friction;
        }

    }
    

}
