using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElseIfScriot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int score = 75;

        if (score >= 90)
        {
            Debug.Log("A");
        }
        else if (score >= 70)
        {
            Debug.Log("B");
        }
        else if (score >= 50)
        {
            Debug.Log("C");
        }
        else 
        {
            Debug.Log("D");
        }

        string country = "France";

        if (country == "France")
        {
            Debug.Log("This is France.");
        }
        else 
        {
            Debug.Log("This isn't France.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
