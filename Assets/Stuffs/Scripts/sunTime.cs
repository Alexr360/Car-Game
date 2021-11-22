using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunTime : MonoBehaviour
{
    public float timeSpeed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, timeSpeed / 10 * Time.deltaTime); //rotate the sun
    }
}
