using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{

    public GameObject canvas;

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        canvas.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void EndProgram()
    {
        Application.Quit();
    }
}
