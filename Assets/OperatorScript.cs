using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Assignment operators
        int score = 0;
        score += 1;
        score += 5;
        Debug.Log(score);

        // Arithmetic operators
        int A = 5;
        int B = 7;
        int C = A + B;
        Debug.Log(C);

        // Subtraction operators
        score -= 2;
        B = A - 3;

        // Multiplication
        score *= 5;
        int D = A * 2;

        // Division
        score /= 2;
        int E = D / 3;

        float jumpHeight = 5.2f;
        jumpHeight *= 1.5f;

        string message = "Hello " + "World" + " and everything else.";

        int sum = A + B + C + D + E;

        float money = 10f;
        money += 5;
        money *= 2;
        money -= 3;
        money /= 2;
        Debug.Log("Player money: "+money);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
