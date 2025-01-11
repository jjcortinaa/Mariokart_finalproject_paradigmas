using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;


    public List<Characters> characters;
    public List<GameObject> AgentsAI;

    private void Awake()
    {
        if (GameManager.Instance == null)
        {
            GameManager.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }




}
