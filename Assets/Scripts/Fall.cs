using UnityEngine;
using UnityEngine.SceneManagement;
public class Fall : MonoBehaviour
{



    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(3);
    }
}
