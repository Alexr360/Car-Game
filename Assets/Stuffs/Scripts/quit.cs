using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    public void quitfunction()
    {
        Debug.Log("Quiting");
        Application.Quit();
    }
}
