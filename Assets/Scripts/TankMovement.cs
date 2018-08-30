using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float speed;

    private float maxSpeed = 50;
    private float acceleration = 5;

    [SerializeField]
    private bool isAccelerating;

    private void Update()
    {
        if (isAccelerating)
        {
            if (speed < maxSpeed)
            {
                speed = Mathf.Min(speed + acceleration * Time.deltaTime, maxSpeed);
            }
        }
        else
        {
            speed -=  acceleration * Time.deltaTime;
            if (speed <= 0)
            {
                speed = 0;
            }
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void Accelerate ()
    {
        isAccelerating = true;
    }

    public void Deccelerate ()
    {
        isAccelerating = false;
    }
}
