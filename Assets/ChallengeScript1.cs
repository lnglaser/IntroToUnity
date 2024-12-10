using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string countryName = "Yamato";
        int population = 3460000;
        float highestAlt = 7498.47f;
        bool isLandLocked = false;

        Debug.Log("Country name: " + countryName);
        Debug.Log("Population: " + population);
        Debug.Log("Highest altitude: " + highestAlt);
        Debug.Log("Landlocked: " + isLandLocked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
