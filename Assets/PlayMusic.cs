using UnityEngine;

public class PlayMusic : MonoBehaviour
{

    public AudioSource gameMusic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameMusic.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
