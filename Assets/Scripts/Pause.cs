using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public Sprite PlaySprite, PauseSprite;
    public GameObject PauseGO;
    public Image ImageButton;

    public void PauseGame()
    {
        if (Time.timeScale > 0)
        {
            Time.timeScale = 0;
            ImageButton.sprite = PlaySprite;
            PauseGO.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            ImageButton.sprite = PauseSprite;
            PauseGO.SetActive(false);
        }
    }
}
