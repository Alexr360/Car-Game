using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wipestick : MonoBehaviour
{
    public bool displayExplosive = false;
    public GameObject vaporizationParticle;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name != "body" || collision.gameObject.name != "Front Wheel" || collision.gameObject.name != "Rear Wheel" || collision.gameObject.name != "Rear Wheel 2")
        {
            if (displayExplosive)
            {
                Instantiate(vaporizationParticle, collision.gameObject.transform.position, Quaternion.identity);
            }
            Debug.Log("Destroyed " + collision.gameObject);
            Destroy(collision.gameObject);//Destroy the object that the stick collided with
        }
    }
}
