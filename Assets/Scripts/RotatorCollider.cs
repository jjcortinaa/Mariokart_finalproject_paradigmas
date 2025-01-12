using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorCollider : MonoBehaviour
{
    public int angle;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {

        GameObject player = other.gameObject;
        AIMovement aIMovement = player.GetComponent<AIMovement>();
        aIMovement.RotateObject(angle);

    }
}