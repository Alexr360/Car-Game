using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goBehind : MonoBehaviour
{
    public GameObject objectToGoBehind;
    public bool endCondition = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (endCondition)
            {
                objectToGoBehind.SetActive(true);
            }
            else
            {
                objectToGoBehind.SetActive(false);
            }
            Destroy(this.gameObject);
        }
    }
}
