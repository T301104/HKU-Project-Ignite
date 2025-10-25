using UnityEngine;

public class FireWall : MonoBehaviour
{
    public float damage;
    public PlayerDamage playerDamage;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            playerDamage.TakeDamage(damage);
        }
    }




}
