using UnityEngine;

public class PauseGame : MonoBehaviour
{

    public GameObject canvas;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown((KeyCode.Space))) 
        {

            // Stops time and opens the pause menu
            Time.timeScale = 0f;
            canvas.SetActive(true);

        }
    }
}
