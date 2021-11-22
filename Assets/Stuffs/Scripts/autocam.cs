using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autocam : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Canvas>().worldCamera = GameObject.Find("Main Camera  (Update For Car Change)").GetComponent<Camera>();
    }
}
