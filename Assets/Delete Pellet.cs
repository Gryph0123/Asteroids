using UnityEngine;

public class DeletePellet : MonoBehaviour
{
    // Sets the maximum time that that the pellet can exist
    public float decayTime;
    float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > decayTime)
        {
            this.gameObject.SetActive(false);
        }
    }
}
