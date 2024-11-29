using Unity.VisualScripting;
using UnityEngine;

public class ShootPellet : MonoBehaviour
{
    public GameObject pellet;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {

            // Creates the pellet at the ship's position
            Instantiate(pellet, transform.position, Quaternion.identity);

        }
    }
}
