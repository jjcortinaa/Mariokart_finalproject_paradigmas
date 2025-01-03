using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCollider : MonoBehaviour
{
    private PositionController positionController;
    private Vector3 pos;
    private Quaternion rot;

    void Start()
    {
        // Guarda la posición inicial del objeto con este script
        pos = transform.position;
        rot = transform.rotation * Quaternion.Euler(0f, 270f, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Intenta obtener el componente PositionController del objeto con el que colisionaste
        positionController = other.gameObject.GetComponent<PositionController>();

        // Verifica si el componente existe
        if (positionController != null)
        {
            // Si existe, actualiza la posición usando su método SetPosition
            positionController.SetPosition(pos);
            positionController.setRotation(rot);
        }
        else
        {
            Debug.LogWarning("El objeto no tiene un componente PositionController: " + other.gameObject.name);
        }
    }
}
