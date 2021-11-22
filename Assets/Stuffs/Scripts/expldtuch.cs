using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class expldtuch : MonoBehaviour
{

    Collider2D[] inExplosiveRadius = null;
    [SerializeField] private float ExplosiveForce = 5f;
    [SerializeField] private float ExplosiveRadius = 5f;
    public GameObject explosiveParticle1;
    public GameObject explosiveParticle2;
    private bool explostog = false;
    private bool partexpl = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>() != null) {
            explostog = true;
            partexpl = false;
        }
    }

    void Update()
    {
        if (explostog == true) {
            inExplosiveRadius = Physics2D.OverlapCircleAll(transform.position, ExplosiveRadius);
            
            foreach (Collider2D o in inExplosiveRadius)
            {
                Rigidbody2D o_rigidbody = o.GetComponent<Rigidbody2D>();
                if(o_rigidbody != null && !o.GetComponent<expldtuch>())
                {
                    if (partexpl != true) {
                        Instantiate(explosiveParticle1, transform.position, Quaternion.identity);
                        Instantiate(explosiveParticle2, transform.position, Quaternion.identity);
                        partexpl = true;
                    }
                    Vector2 distanceVector = o.transform.position - transform.position;
                    if (distanceVector.magnitude > 0)
                    {
                        o_rigidbody.AddForce(distanceVector.normalized * ExplosiveForce / distanceVector.magnitude, ForceMode2D.Impulse);
                    }
                    Destroy(gameObject);
                }
            }
        }
    }
}
