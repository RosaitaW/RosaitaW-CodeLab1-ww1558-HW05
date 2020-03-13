using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrizeScript : MonoBehaviour
{
    public static int currentLevel = 0;
    public int targetScore;


    
    // Start is called before the first frame update
    void Start()
    {
        targetScore = GameManager.instance.Score * 2 + 6; //increase the target score every level
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision) //If another GameObject with a 2D Collider on it hits this GameObject's collider
    {
        GameManager.instance.Score++; //increase the player's score using the Singleton!
        Debug.Log("Score: " + GameManager.instance.Score); //print the score to console, using the Singleton
        Destroy(gameObject); //teleport to a random location

    }
}