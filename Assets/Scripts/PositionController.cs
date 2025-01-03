using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionController : MonoBehaviour
{
    private Vector3 currentPos = new Vector3(0,0,0);
    private Quaternion currentRot;
    public Quaternion CurrentRot => currentRot;
    public Vector3 CurrentPos => currentPos;
    // Start is called before the first frame update

    public void SetPosition(Vector3 vector3)
    {
        currentPos = vector3;
        
    }
    public void setRotation(Quaternion rotation)
    {
        currentRot = rotation;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
