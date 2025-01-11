using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerColliderObject : MonoBehaviour
{
    private HashSet<GameObject> objectsInArea = new HashSet<GameObject>();
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
        if (!objectsInArea.Contains(other.gameObject))
        {
            GameObject player = other.gameObject;
            objectsInArea.Add(player);
            AIMovement aIMovement = player.GetComponent<AIMovement>();
            aIMovement.RotateObject(angle);

        }
    }
}