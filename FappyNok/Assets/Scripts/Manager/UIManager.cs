using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}
