using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seasonalcolorchanger : MonoBehaviour
{
    private GameObject[] objectsToChange;
    private GameObject sunTime;

    void Start()
    {
        sunTime = GameObject.Find("Sun Spinner");
        InvokeRepeating("SlowUpdate", 0.0f, 10f);
        objectsToChange = GameObject.FindGameObjectsWithTag("SEASONAL");
    }

    public void SlowUpdate()
    {
        float time = sunTime.GetComponent<sunTime>().currentSeason;
        if (time < 1)
        {
            //winter
            Debug.Log("winter");
            foreach (GameObject obj in objectsToChange)
            {
                SpriteRenderer color = obj.GetComponent<SpriteRenderer>();
                color.color = Color.Lerp(Color.yellow, Color.white, time);
            }

        }
        else if (time < 2)
        {
            //spring
            Debug.Log("spring");
            foreach (GameObject obj in objectsToChange)
            {
                SpriteRenderer color = obj.GetComponent<SpriteRenderer>();
                color.color = Color.Lerp(Color.white, Color.green, time-1);
            }

        }
        else if (time < 3)
        {
            //summer
            Debug.Log("summer");
            foreach (GameObject obj in objectsToChange)
            {
                SpriteRenderer color = obj.GetComponent<SpriteRenderer>();
                color.color = Color.Lerp(Color.green, Color.green, time-2);
            }

        }
        else
        {
            //fall
            Debug.Log("fall");
            foreach (GameObject obj in objectsToChange)
            {
                SpriteRenderer color = obj.GetComponent<SpriteRenderer>();
                color.color = Color.Lerp(Color.green, Color.yellow, time-3);
            }

        }
    }

}