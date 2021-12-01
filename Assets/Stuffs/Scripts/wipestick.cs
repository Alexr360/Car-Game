using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wipestick : MonoBehaviour
{
    public bool destryoElement = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name != "Player" && !collision.gameObject.name.Contains("Wiper"))
        {
            if (destryoElement)
            {
                Debug.Log("Destroyed " + collision.gameObject);
                Destroy(collision.gameObject);//Destroy the object that the stick collided with
            }
            else
            {
                Debug.Log("Disabled " + collision.gameObject);
                collision.gameObject.SetActive(false);
            }
        }
    }
}
