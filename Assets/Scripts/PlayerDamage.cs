using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    public float MaxHealth = 10;
    public float Health;


    private void Start()
    {
        Health = MaxHealth;
    }



    public void TakeDamage(float damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            OnDeath();
        }



    }

    private void OnDeath() 
    {
        SceneManager.LoadScene("GameOver");
    }
    

}
