using UnityEngine;

public class Movement : MonoBehaviour
{
    // Gets the rigidbody of the object
    public Rigidbody2D rb;
    public float speed;
    public float angularVelocity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        // Moves the ship forward
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity += speed * new Vector2(transform.up.x, transform.up.y) * Time.deltaTime;
        }

        // Rotates the ship clockwise
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-angularVelocity * Time.deltaTime * transform.forward);
        }

        // Rotates the ship counterclockwise
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(angularVelocity * Time.deltaTime * transform.forward);
            
        }
    }
}
