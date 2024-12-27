using System.Collections;
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour
{
    public GameObject countDown;
    public GameObject lapTimer;

    void Start()
    {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        lapTimer.SetActive(false);
        CarController.canMove = false;

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
        CarController.canMove = true;
    }
}
