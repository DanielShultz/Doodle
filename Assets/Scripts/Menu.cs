using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ToGame()
    {
        Debug.Log("Click");
        SceneManager.LoadScene(1);
    }
}
