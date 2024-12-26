using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    public static int minuteCount;
    public static int secondCount;
    public static float miliCount;
    public static string miliDisplay;

    public GameObject minuteBox;
    public GameObject secondBox;
    public GameObject miliBox;





    void Update()
    {
        miliCount += Time.deltaTime * 10;
        miliDisplay = miliCount.ToString("F0");
        miliBox.GetComponent<TextMeshProUGUI>().text = "" + miliDisplay;

        if (miliCount >= 10)
        {
            miliCount = 0;
            secondCount += 1;
        }

        if (secondCount <= 9)
        {
            secondBox.GetComponent<TextMeshProUGUI>().text = "0" + secondCount + ".";

        }
        else
        {
            secondBox.GetComponent<TextMeshProUGUI>().text = "" + secondCount + ".";
        }

        if (secondCount >= 60)
        {
            secondCount = 0;
            minuteCount += 1;
        }
        if (minuteCount <= 9)
        {
            minuteBox.GetComponent<TextMeshProUGUI>().text = "0" + minuteCount + ":";

        }
        else
        {
            minuteBox.GetComponent<Text>().text = "" + minuteCount + ":";
        }
    }
}
