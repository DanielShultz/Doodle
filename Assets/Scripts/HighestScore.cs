using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighestScore : MonoBehaviour
{
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "Highest Score: " + Score.MaxScore.ToString();
    }
}

