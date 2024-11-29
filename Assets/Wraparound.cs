using UnityEngine;

public class Wraparound : MonoBehaviour
{

    // Gets the dimentions of the screen
    public float borderHeight = Camera.main.orthographicSize;
    public float left;
    public float right;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        borderHeight = Camera.main.orthographicSize;
        float aspect = Camera.main.aspect;
        left = -borderHeight * aspect;
        right = borderHeight * aspect;
        right = borderHeight * aspect;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > borderHeight)
        {
            transform.position = new Vector3(transform.position.x, - borderHeight, 0f);
        }
        else if (transform.position.y < -borderHeight)
        {
            transform.position = new Vector3(transform.position.x, borderHeight, 0f);
        }
        else if (transform.position.x > right)
        {
            transform.position = new Vector3(left, transform.position.y, 0f);
        }
        else if (transform.position.x < left)
        {
            transform.position = new Vector3(right, transform.position.y, 0f);
        }
    }
}
