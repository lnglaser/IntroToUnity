using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int score = 10;

        if(score == 10)
        {
            Debug.Log("Player has won!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
