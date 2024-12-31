using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int playerHealth = 100;
        Debug.Log(playerHealth);
        playerHealth = 50;
        Debug.Log(playerHealth);

        float moveSpeed = 5.25f;
        Debug.Log(moveSpeed);

        string playerName = "Steve";
        playerName = "Stephan";

        bool gameOver = false;
        gameOver = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
