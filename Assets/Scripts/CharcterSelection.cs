using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class CharcterSelection : MonoBehaviour
{
    private int index;

    [SerializeField] private Image image;

    [SerializeField] private TextMeshProUGUI charname;

    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.Instance;

        index = PlayerPrefs.GetInt("PlayerIndex");

        if (index > gameManager.characters.Count - 1)
        {
            index = 0;
        }

        ChangeScreen();
    }

    private void ChangeScreen()
    {
        PlayerPrefs.SetInt("PlayerIndex", index);
        image.sprite = gameManager.characters[index].image;
        charname.text = gameManager.characters[index].charname;
    }

    public void NextCharacter()
    {
        if(index == gameManager.characters.Count - 1)
        {
            index = 0;
        }
        else
        {
            index += 1;
        }
        ChangeScreen();
    }

    public void PreviousCharacter()
    {
        if (index == 0)
        {
            index = gameManager.characters.Count - 1;
        }
        else
        {
            index -= 1;
        }
        ChangeScreen();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
