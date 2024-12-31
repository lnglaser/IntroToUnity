using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 movement = new Vector3(1, 0, 1);
        //transform.position += movement;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
    }
}
