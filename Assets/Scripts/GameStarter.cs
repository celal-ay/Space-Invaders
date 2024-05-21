using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;      // This is necessary for the changing scenes.

public class GameStarter : MonoBehaviour // This script has a very simple mission, just will change the scene Menu to Main. So the player believes the game is started.
{                                        // Again it will attached to ScriptObject.
   public void ChangeScene()
    {
        SceneManager.LoadScene("Main");
        if(InputReceiver.Instance.username == "") // Checking if user has entered an username
        {
            SceneManager.LoadScene("Menu");
            Debug.Log("Please enter an username.");
        }
    }
}
