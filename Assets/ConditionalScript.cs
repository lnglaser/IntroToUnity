using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int score = 3;

        if(score == 10)
        {
            Debug.Log("Player has won!");
        }

        if(score !=10)
        {
            Debug.Log("Player does not have 10 points.");
        }

        int health = 50;

        if(health <= 0)
        {
            Debug.Log("Player has been destroyed.");
        }

        if (health > 0) 
        {
            Debug.Log("Player still has health.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
