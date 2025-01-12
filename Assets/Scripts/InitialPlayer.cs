using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        int playerIndex = PlayerPrefs.GetInt("PlayerIndex");
        GameObject selectedCar = Instantiate(GameManager.Instance.characters[playerIndex].characterPlay, transform.position, Quaternion.identity);
        ChangeTagRecursively(selectedCar, "Player");

        for (int i=1; i<2; i++)
        {
            GameObject aiCar = Instantiate(GameManager.Instance.AgentsAI[(playerIndex + i) % 4], transform.position + new Vector3(0, 0, +2), Quaternion.identity);
            ChangeTagRecursively(aiCar, "Player");
        }
    }
    public void ChangeTagRecursively(GameObject parent, string newTag)
    {
        parent.tag = newTag;

        foreach (Transform child in parent.transform)
        {
            ChangeTagRecursively(child.gameObject, newTag);
        }
    }

}
