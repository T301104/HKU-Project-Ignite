using UnityEngine;

public class FireFloor : MonoBehaviour
{
    public float damage;
    public PlayerDamage playerDamage;

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
}
