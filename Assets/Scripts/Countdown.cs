using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{

    public GameObject countDown;
    public GameObject lapTimer;
    public GameObject carControls;

    void Start()
    {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        lapTimer.SetActive(false);
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
        carControls.SetActive(true);
    }
}
