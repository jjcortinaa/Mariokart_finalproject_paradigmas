using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControllerActive : MonoBehaviour
{

    public GameObject CarControl;

    void Start()
    {
        CarControl.GetComponent<CarController>().enabled = true;
    }
}
