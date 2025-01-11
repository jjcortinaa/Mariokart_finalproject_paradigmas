using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        int playerIndex = PlayerPrefs.GetInt("PlayerIndex");
        GameObject selectedCar = Instantiate(GameManager.Instance.characters[playerIndex].characterPlay, transform.position, Quaternion.identity);
        selectedCar.tag = "Player";

        for (int i=1; i<4; i++)
        {
            if (i == 1)
            {
                GameObject aiCar = Instantiate(GameManager.Instance.AgentsAI[(playerIndex + i) % 4], transform.position + new Vector3(-2, 0, 0), Quaternion.identity);

            }
            if (i == 2)
            {
                GameObject aiCar = Instantiate(GameManager.Instance.AgentsAI[(playerIndex + i) % 4], transform.position + new Vector3(0, 0, -2), Quaternion.identity);

            }
            if (i == 3)
            {
                GameObject aiCar = Instantiate(GameManager.Instance.AgentsAI[(playerIndex + i) % 4], transform.position + new Vector3(-2, 0, -2), Quaternion.identity);

            }
            //aiCar.tag = "AI";
        }
    }

}
