using UnityEngine;

public class PlaySoundEffects : MonoBehaviour
{
    public AudioSource thrustSound;
    public AudioSource shootSound;
    public AudioSource teleportSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && !thrustSound.isPlaying) 
        { 
            thrustSound.Play();
        }

        if (Input.GetKeyDown(KeyCode.S)) 
        {
            shootSound.Play();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            teleportSound.Play();
        }
    }

    
}
