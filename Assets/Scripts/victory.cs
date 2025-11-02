using UnityEngine;
using UnityEngine.SceneManagement;

public class victory : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(4);
    }
}
