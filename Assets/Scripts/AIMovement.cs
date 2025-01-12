using UnityEngine;

public class AIMovement : MonoBehaviour
{
    private const float VInput = 0.8f;
    private float driveSpeed = 50f;
    private float steerSpeed = 25f;
    private int performance = 0;
    private int maxTurnAngle = 10;
    public WheelCollider lfW, rfW, lbW, rbW;
    public Transform lfWTransform, rfWTransform, lbWTransform, rbWTransform;
    public static bool canMove = false;

    private void FixedUpdate()
    {
        if (canMove == true)
        {
            ForwardMovement();
            //SidewaysMovement();
        }

    }

    private void ForwardMovement()
    {
        float motorForce = VInput * driveSpeed;
        lfW.motorTorque = motorForce;
        rfW.motorTorque = motorForce;
        lbW.motorTorque = motorForce;
        rbW.motorTorque = motorForce;


    }
    /*
    private void SidewaysMovement()
    {
        float currentTurnAngle = maxTurnAngle * Random.Range(-0.01f, 0.01f);
        lfW.steerAngle = currentTurnAngle;
        rfW.steerAngle = currentTurnAngle;

        UpdateWheel(lfW, lfWTransform);
        UpdateWheel(rfW, rfWTransform);
    }
    */



    void UpdateWheel(WheelCollider collider, Transform transform)
    {
        Vector3 position;
        Quaternion rotation;
        collider.GetWorldPose(out position, out rotation);

        transform.position = position;
        transform.rotation = rotation;
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


