using UnityEngine;

public class FireWall : MonoBehaviour
{
    public float damage;
    public PlayerDamage playerDamage;

    [SerializeField] private float acceleration;
    [SerializeField] private float deseleration;
    [SerializeField] private float maxSpeed;
    

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            if (collision.transform.position.x <= transform.position.x) 
            {
                playerDamage.KockFromRicht = true;
            }
            if (collision.transform.position.x > transform.position.x)
            {
                playerDamage.KockFromRicht = false;
            }

            playerDamage.TakeDamage(damage);
        }
    }

    private void Update()
    {
        rb.AddForce(1 * acceleration, 0, 0, ForceMode.Force);
        if (rb.linearVelocity.magnitude > maxSpeed) 
        {
            rb.linearVelocity = rb.linearVelocity * maxSpeed;
        }
    }


}
