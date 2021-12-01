using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunTime : MonoBehaviour
{
    public float timeSpeed = 1;
    public float currentSeason = 2;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, timeSpeed / 10 * Time.deltaTime); //rotate the sun
        currentSeason = currentSeason + timeSpeed / 14000 * Time.deltaTime;
        if (currentSeason > 4) { currentSeason = 0; }
    }
}
