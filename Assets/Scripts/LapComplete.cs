using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LapComplete : MonoBehaviour
{
    public GameObject lapCompleteTrigger;
    public GameObject halfLapTrigger;

    public GameObject minDisplay;
    public GameObject secDisplay;
    public GameObject miliDisplay;

    public GameObject lapTimeBox;

    private void OnTriggerEnter()
    {
        if (LapTimeManager.secondCount <= 9)
        {
            secDisplay.GetComponent<TextMeshProUGUI>().text = "0" + LapTimeManager.secondCount + ".";
        }
        else
        {
            secDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManager.secondCount + ".";

        }
        if (LapTimeManager.minuteCount <= 9)
        {
            minDisplay.GetComponent<TextMeshProUGUI>().text = "0" + LapTimeManager.minuteCount + ".";
        }
        else
        {
            minDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManager.minuteCount + ".";

        }
        miliDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManager.miliCount;
        LapTimeManager.minuteCount = 0;
        LapTimeManager.secondCount = 0;
        LapTimeManager.miliCount = 0;

        halfLapTrigger.SetActive(true);
        lapCompleteTrigger.SetActive(false);

    }



}
