using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    public float MaxHealth = 10;
    public float Health;
    public float KockBackForce;
    public float KockBackCounter;
    public float KockBackTotalTime;

    public bool KockFromRicht;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Health = MaxHealth;
    }



    public void TakeDamage(float damage)
    {
        Health -= damage;

        

        if (Health <= 0)
        {
            OnDeath();
        }

        if (KockFromRicht == true)
        {
            rb.linearVelocity = new Vector3(-KockBackForce, KockBackForce * 1.5f, 0);
        }

        if (KockFromRicht == false)
        {
            rb.linearVelocity = new Vector3(KockBackForce, KockBackForce * 1.5f, 0);
        }

    }

    private void OnDeath() 
    {
        SceneManager.LoadScene("GameOver");
    }


}
