using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void singleplayer()
    {
        SceneManager.LoadScene("Singleplayer");
    }

    public void multiplayer()
    {
        SceneManager.LoadScene("Multiplayer");
    }

    public void backtomain()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
