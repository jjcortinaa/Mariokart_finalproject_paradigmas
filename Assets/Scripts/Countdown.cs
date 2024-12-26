using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{
    public CarController carController;
    public GameObject countDown;
    public GameObject lapTimer;
    

    void Start()
    {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        while (carController == null)
        {
            GameObject car = GameObject.FindWithTag("Player");
            if (car != null)
            {
                carController = car.GetComponent<CarController>();
                if (carController == null)
                {
                    Debug.LogError("El coche encontrado no tiene un componente CarController2.");
                }
            }
            yield return null;
        }

        lapTimer.SetActive(false);
        carController.canMove = false;
        yield return new WaitForSeconds(0.5f);
        countDown.GetComponent<TextMeshProUGUI>().text = "3";
        countDown.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        countDown.GetComponent<TextMeshProUGUI>().text = "2";
        countDown.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        countDown.GetComponent<TextMeshProUGUI>().text = "1";
        countDown.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        lapTimer.SetActive(true);
        carController.canMove = true;

    }
}
