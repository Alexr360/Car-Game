using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float movementSpeed = 10;
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed / 4, 0);
    }
}
