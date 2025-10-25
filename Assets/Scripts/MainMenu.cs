using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject mainMenu;


    public void Play()
    {
        SceneManager.LoadScene("Level01");
    }

    public void Options()
    {

    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }



}
