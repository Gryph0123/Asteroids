using UnityEngine;

public class DetectPelletStrike : MonoBehaviour
{

    public int asteroidHealth;
    SpriteRenderer sprite;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        asteroidHealth = Random.Range(0, 3);
        sprite = GetComponent<SpriteRenderer>();

        if (asteroidHealth == 0)
        {
            sprite.color = Color.red;
        }

        else if (asteroidHealth == 1)
        {
            sprite.color = Color.yellow;
        }

        else
        {
            sprite.color = Color.white;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        // Checks that the asteroid is colliding with the pellet
        if (collision.CompareTag("Pellet"))
        {
            asteroidHealth--;

            // Removes the asteroid if it has no more health
            if (asteroidHealth < 0)
            {
                gameObject.SetActive(false);
            }

            else if (asteroidHealth == 0)
            {
                sprite.color = Color.red;
            }

            else if (asteroidHealth == 1)
            {
                sprite.color = Color.yellow;
            }

            else
            {
                sprite.color = Color.white;
            }


            
        }
    }
}
