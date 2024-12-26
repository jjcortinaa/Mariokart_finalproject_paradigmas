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
    }

}
