using System;
using UnityEngine;

public class FallManager : MonoBehaviour
{
    public event Action<GameObject> FallingCarActions;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        GameObject collindantObject = collision.gameObject;
        ManageCollision(collindantObject);
    }
    void ManageCollision(GameObject gameObject)
    {
        FallingCarActions?.Invoke(gameObject);
    }
}
