using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGameButton : MonoBehaviour
{
    //Button to start the game

    public void OnMouseDown()
    {
        StartGameClick();
    }

    public void StartGameClick()
    {
        SceneManager.LoadScene("MainGame");
        Debug.Log("Scene Transition");
    }
}
