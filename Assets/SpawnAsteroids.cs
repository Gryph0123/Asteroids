using Unity.Hierarchy;
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
            // 1 = left
            // 2 = bottom
            // 3 = right
            int screenSidePicker = Random.Range(0, 4);

            if (screenSidePicker == 0) 
            {

                // Create new asteroid and apply a position to it
                GameObject newAsteroid = Object.Instantiate(asteroidPrefab, 
                   new Vector3(Random.Range(left, right), borderHeight, 0f),
                   Quaternion.identity);

                Rigidbody2D newAsteroidRigidBody = newAsteroid.GetComponent<Rigidbody2D>(); // Calls the rigidbody of the asteroid

                // Resizes the asteroid to some ramomized value.
                newAsteroid.transform.localScale = Random.Range(minAsteroidSize, maxAsteroidSize) * Vector3.one;

                // Sets the velocity to some random vector
                float asteroidSpeed = Random.Range(minAsteroidSpeed, maxAsteroidSpeed);
                float asteroidAngle = Random.Range(Mathf.PI, 2*Mathf.PI);
                newAsteroidRigidBody.velocity = new Vector2(asteroidSpeed * Mathf.Cos(asteroidAngle), asteroidSpeed * Mathf.Sin(asteroidAngle));

                newAsteroidRigidBody.angularVelocity = Random.Range(-maxAngularVelocity, maxAngularVelocity); // Sets the angular velocity of the asteroid

            }

            else if (screenSidePicker == 1) 
            {
                // Create new asteroid and apply a position to it
                GameObject newAsteroid = Object.Instantiate(asteroidPrefab,
                   new Vector3(left, Random.Range(-borderHeight, borderHeight), 0f),
                   Quaternion.identity);

                Rigidbody2D newAsteroidRigidBody = newAsteroid.GetComponent<Rigidbody2D>(); // Calls the rigidbody of the asteroid

                // Resizes the asteroid to some ramomized value.
                newAsteroid.transform.localScale = Random.Range(minAsteroidSize, maxAsteroidSize) * Vector3.one;

                // Sets the velocity to some random vector
                float asteroidSpeed = Random.Range(minAsteroidSpeed, maxAsteroidSpeed);
                float asteroidAngle = Random.Range(-Mathf.PI / 2, Mathf.PI / 2);
                newAsteroidRigidBody.velocity = new Vector2(asteroidSpeed * Mathf.Cos(asteroidAngle), asteroidSpeed * Mathf.Sin(asteroidAngle));

                newAsteroidRigidBody.angularVelocity = Random.Range(-maxAngularVelocity, maxAngularVelocity); // Sets the angular velocity of the asteroid
            }

            else if (screenSidePicker == 2)
            {
                // Create new asteroid and apply a position to it
                GameObject newAsteroid = Object.Instantiate(asteroidPrefab,
                   new Vector3(Random.Range(left, right), -borderHeight, 0f),
                   Quaternion.identity);

                Rigidbody2D newAsteroidRigidBody = newAsteroid.GetComponent<Rigidbody2D>(); // Calls the rigidbody of the asteroid

                // Resizes the asteroid to some ramomized value.
                newAsteroid.transform.localScale = Random.Range(minAsteroidSize, maxAsteroidSize) * Vector3.one;

                // Sets the velocity to some random vector
                float asteroidSpeed = Random.Range(minAsteroidSpeed, maxAsteroidSpeed);
                float asteroidAngle = Random.Range(0, Mathf.PI);
                newAsteroidRigidBody.velocity = new Vector2(asteroidSpeed * Mathf.Cos(asteroidAngle), asteroidSpeed * Mathf.Sin(asteroidAngle));

                newAsteroidRigidBody.angularVelocity = Random.Range(-maxAngularVelocity, maxAngularVelocity); // Sets the angular velocity of the asteroid
            }

            else
            {
                // Create new asteroid and apply a position to it
                GameObject newAsteroid = Object.Instantiate(asteroidPrefab,
                   new Vector3(right, Random.Range(-borderHeight, borderHeight), 0f),
                   Quaternion.identity);

                Rigidbody2D newAsteroidRigidBody = newAsteroid.GetComponent<Rigidbody2D>(); // Calls the rigidbody of the asteroid
               
                // Resizes the asteroid to some ramomized value.
                newAsteroid.transform.localScale = Random.Range(minAsteroidSize, maxAsteroidSize) * Vector3.one;

                // Sets the velocity to some random vector
                float asteroidSpeed = Random.Range(minAsteroidSpeed, maxAsteroidSpeed);
                float asteroidAngle = Random.Range(Mathf.PI / 2, 3 * Mathf.PI / 2);
                newAsteroidRigidBody.velocity = new Vector2(asteroidSpeed * Mathf.Cos(asteroidAngle), asteroidSpeed * Mathf.Sin(asteroidAngle));

                newAsteroidRigidBody.angularVelocity = Random.Range(-maxAngularVelocity, maxAngularVelocity); // Sets the angular velocity of the asteroid
            }


            
        }
    }
}
