using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float number = Add(2.5f, 4.76f);
        Debug.Log("Sum: "+number);
    }

    float Add(float a, float b)
    {
        float sum = a + b;
        return sum;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
