using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class ShootPellet : MonoBehaviour
{
    public GameObject pellet;
    Rigidbody2D rb;
    public float shootingSpeed;
    Rigidbody2D playerRb;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Gets the player's rigidbody
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            // Creates the pellet at the ship's position
            GameObject newPellet = Instantiate(pellet, transform.position, Quaternion.identity);

            // Calls the pellet's rigidbody and assigns a speed to it
            rb = newPellet.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(transform.up.x, transform.up.y) * shootingSpeed + playerRb.velocity;


        }
    }
}
