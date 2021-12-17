using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randSlide : MonoBehaviour
{
    public float minXDispalcement = -1;
    public float maxXDispalcement = 1;
    void Start()
    {
        Debug.Log(minXDispalcement);
        float xgafdgadf = Random.Range(minXDispalcement, maxXDispalcement);
        transform.localPosition = new Vector3(xgafdgadf, transform.localPosition.y, transform.localPosition.z);
        Debug.Log(xgafdgadf);
    }
}
    