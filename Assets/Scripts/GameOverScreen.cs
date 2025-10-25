using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void Restart() 
    {
        SceneManager.LoadScene("Level01");
    }

    public void MainMenu() 
    {
        SceneManager.LoadScene("MainMenu");
    }
}
