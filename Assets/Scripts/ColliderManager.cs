using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderManager : MonoBehaviour
{
    private FallManager fallManager = new FallManager();
    private Rigidbody rb;
    private PositionController pc;
    private Vector3 zero = new Vector3(0, 0, 0);
    private Vector3 origin = new Vector3(0, 0, 0);
    private bool found = false;

    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        fallManager = FindObjectOfType<FallManager>();
        if (!found)
        {
            fallManager.FallingCarActions += HandleFall;
            found = true;
        }


        
    }
    private void HandleFall(GameObject gameObject)
    {
        rb = gameObject.GetComponent<Rigidbody>();
        pc = gameObject.GetComponent<PositionController>();
        gameObject.transform.position = pc.CurrentPos;
        gameObject.transform.rotation = pc.CurrentRot;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

    }
}
