using UnityEngine;

public class TeleportShip : MonoBehaviour
{

    // Gets the dimentions of the screen
    public float borderHeight;
    public float left;
    public float right;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        borderHeight = Camera.main.orthographicSize;
        float aspect = Camera.main.aspect;
        left = -borderHeight * aspect;
        right = borderHeight * aspect;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        { 
            transform.position = new Vector3(Random.Range(left, right), Random.Range(-borderHeight, borderHeight), 0f);
        }
    }
}
