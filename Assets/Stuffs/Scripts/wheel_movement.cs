using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheel_movement : MonoBehaviour
{
    public GameObject poweredWheels;
    public GameObject groundScannar;
    public float torque = 100;
    public float maxspeed = 5000;
    Component[] wheels;
    JointMotor2D jointMotor;

    // Start is called before the first frame update
    void Start()
    {
        wheels = poweredWheels.GetComponentsInChildren<WheelJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right") || Input.GetKey("d")) {
            foreach (WheelJoint2D wheel in wheels)
            {
                jointMotor.motorSpeed = maxspeed;
                jointMotor.maxMotorTorque = torque;
            }
        }
        else if (Input.GetKey("left") || Input.GetKey("a"))
        {
            foreach (WheelJoint2D wheel in wheels)
            {
                jointMotor.motorSpeed = -maxspeed / 3;
                jointMotor.maxMotorTorque = torque / 2;
            }
        }
        else {
            foreach (WheelJoint2D wheel in wheels)
            {
                jointMotor.motorSpeed = 0;
            }
        }


        // changes the motors
        foreach (WheelJoint2D wheel in wheels)
        {
            wheel.motor = jointMotor;
        }
    }
}

