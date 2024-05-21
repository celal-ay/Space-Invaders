using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class InputReceiver : MonoBehaviour
{
    public TMPro.TMP_InputField InputField; // Receives the Input. (Attached ScriptObject and ScriptObject attached InputField's EndEdit;
    public static InputReceiver Instance; // I will use for Singleton. Input will be preserved.

    public string username; // This variable is public because of my other GameStarted script will test it whether Null or something.


    void Awake()
    {
        if(Instance == null)  // Singleton.
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    public void TakeInput()
    {
        username = InputField.text;
        Debug.Log(username);
    }
}
