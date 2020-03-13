using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minusScript : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision) //If another GameObject with a 2D Collider on it hits this GameObject's collider
    {
        if (GameManager.instance.Score > 0)
        {
            GameManager.instance.Score -= 2; //increase the player's score using the Singleton!
            Debug.Log("Score: " + GameManager.instance.Score); //print the score to console, using the Singleton
            transform.position = new Vector2(Random.Range(-8, 8), Random.Range(-4, 2)); //teleport to a random location
        }
        else
        {
            Debug.Log("Score: " + GameManager.instance.Score); //print the score to console, using the Singleton
            transform.position = new Vector2(Random.Range(-8, 8), Random.Range(-4, 2)); //teleport to a random location
        }
    }
}
