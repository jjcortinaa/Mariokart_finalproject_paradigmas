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
    public GameObject lapCounter;
    public int lapsCompleted;
    public int maxLaps = 3;
    public float rawTime;

    public GameObject finishMessage;

    private void Start()
    {
        PlayerPrefs.SetFloat("BestTime", float.MaxValue);
        finishMessage.SetActive(false);
    }

    private void OnTriggerEnter()
    {
        if (LapTimeManager.raceFinished) return;
        lapsCompleted += 1;
        rawTime = PlayerPrefs.GetFloat("BestTime");

        if (LapTimeManager.rawTime <= rawTime)
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
            PlayerPrefs.SetFloat("BestTime", LapTimeManager.rawTime);
        }


        LapTimeManager.rawTime = 0;
        LapTimeManager.minuteCount = 0;
        LapTimeManager.secondCount = 0;
        LapTimeManager.miliCount = 0;
        lapCounter.GetComponent<TextMeshProUGUI>().text = "" + lapsCompleted;

        halfLapTrigger.SetActive(true);
        lapCompleteTrigger.SetActive(false);

        if (lapsCompleted >= maxLaps)
        {

            EndRace();
        }
    }

    private void EndRace()
    {
        LapTimeManager.raceFinished = true;
        CarController.canMove = false;
        finishMessage.SetActive(true);
        
    }


}
