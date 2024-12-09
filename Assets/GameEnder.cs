using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnder : MonoBehaviour
{

    public AudioSource gameEndSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        // Checks that the player is in the collider
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
