using UnityEngine;

public class SpawnAsteroids : MonoBehaviour
{

    public float spawnWaitTime; // Defines the time that the game has to wait before spawning a new asteroid

    public float maxAsteroidSize; // Maximum size of the asteroid

    public float minAsteroidSize; // Minimum size of the asteroid

    // Same as last two variables but with speed
    public float maxAsteroidSpeed;
    public float minAsteroidSpeed;

    public float maxAngularVelocity; // Determines the max speed that the asteroid rotates at when it spawns in

    public float timer; // Keeps track of how long it has been since the last asteroid spawned

    public GameObject asteroidPrefab; // Points to the asteroid gameobject


    // Gets the dimentions of the screen
    public float borderHeight;
    public float left;
    public float right;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // Gets the dimentions of the screen from the camera
        borderHeight = Camera.main.orthographicSize;
        float aspect = Camera.main.aspect;
        left = -borderHeight * aspect;
        right = borderHeight * aspect;
        right = borderHeight * aspect;

    }

    // Update is called once per frame
    void Update()
    {

        // Updates timer
        timer += Time.deltaTime;

        // Time is up and new asteroid must be spawned
        if (timer >= spawnWaitTime)
        {
            timer = 0;

            // Picks what side of the sceen we should spawn the asteroid from
            // 0 = top
            // 1 = right
            // 2 = bottom
            // 3 = left
            int screenSidePicker = Random.Range(0, 4);

            if (screenSidePicker == 0) 
            { 

            }

            if (screenSidePicker == 1) 
            { 

            }

            if (screenSidePicker == 2)
            {

            }

            if (screenSidePicker == 3)
            {

            }


            GameObject newAsteroid = Object.Instantiate(asteroidPrefab);
        }
    }
}
