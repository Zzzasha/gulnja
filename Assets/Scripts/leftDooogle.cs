using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftDooogle : MonoBehaviour
{
    public bool isKeyPress = false;
    public float speed = 0f;
    private HingeJoint2D hingeJoint2D;
    private JointMotor2D jointMotor;


    // Start is called before the first frame update
    void Start()
    {
        hingeJoint2D = GetComponent<HingeJoint2D>();
        jointMotor = hingeJoint2D.motor;

    }

    public void OnMouseDown()
    {
        isKeyPress = true;
    }

    public void OnMouseUp()
    {
        isKeyPress = false;
    }

    void FixedUpdate()
    {
        // on press keyboard or touch Screen
        if (isKeyPress)
        {
            // set motor speed to max
            jointMotor.motorSpeed = speed;
            hingeJoint2D.motor = jointMotor;
        }
        else
        {
            // snap the motor back again
            jointMotor.motorSpeed = -speed;
            hingeJoint2D.motor = jointMotor;
        }

    }
}
