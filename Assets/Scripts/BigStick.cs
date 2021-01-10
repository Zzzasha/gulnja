using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigStick : MonoBehaviour
{
    private bool isPressed = false;
    private Vector2 direction;
    public float acceleration;
    public Rigidbody2D rb;

    void Start()
    {
        direction = new Vector2(0.0f, 1.0f);
    }

    public void OnMouseDown()
    {
        isPressed = true;
    }

    public void OnMouseUp()
    {
        isPressed = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       if(isPressed)
        {
            rb.AddForce(direction.normalized * acceleration);
        }

    }
}
