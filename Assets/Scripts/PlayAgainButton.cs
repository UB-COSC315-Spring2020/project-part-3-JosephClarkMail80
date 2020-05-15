using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayAgainButton : MonoBehaviour
{
    //Button to play again

    public void OnMouseDown()
    {
        PlayAgainClick();
    }

    public void PlayAgainClick()
    {
       SceneManager.LoadScene("MainGame");
        Debug.Log("Scene Transition");
    }
}
