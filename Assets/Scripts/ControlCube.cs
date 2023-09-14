using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCube : MonoBehaviour
{
    public float speed;
    public float modSpeed;
    public float speedMax;
    public float speedMin;
    private void Start()
    {
        speed = 0;
        modSpeed = 0;
    }
    void Update()
    {
        if (modSpeed > speedMax)
        {
            modSpeed = speedMax;
        }
        if (modSpeed < speedMin)
        {
            modSpeed = speedMin;
        }
        if (speed != 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed + modSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
        }
    }
}
