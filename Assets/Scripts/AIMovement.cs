using System.Numerics;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    private const float VInput = 0.8f;
    private float driveSpeed = 50f;
    private float steerSpeed = 25f;
    private int performance = 0;
    public WheelCollider lfW, rfW, lbW, rbW;
    public Transform lfWTransform, rfWTransform, lbWTransform, rbWTransform;

    private void FixedUpdate()
    {

        ForwardMovement();

    }

    private void ForwardMovement()
    {
        float motorForce = VInput * driveSpeed;
        lfW.motorTorque = motorForce;
        rfW.motorTorque = motorForce;
        lbW.motorTorque = motorForce;
        rbW.motorTorque = motorForce;


    }

    public void RotateObject(float angle)
    {
        transform.Rotate(0f, angle, 0f);
    }

    public void UpdatePerformance(int reward = 0)
    {
        performance += reward;
    }


}


