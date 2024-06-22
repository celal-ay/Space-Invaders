using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    
    public GameObject InventoryMenu; // atanacak obje.
    private bool menuActivated; // flag
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && menuActivated) // men� aktifse ve kullan�c� e ye basm��sa atanm�� objeyi deaktive et.
        {
            Time.timeScale = 1;

            InventoryMenu.SetActive(false); // envanteri off
            menuActivated = false;
        }
        else if(Input.GetKeyDown(KeyCode.E) && !menuActivated)
        {
            Time.timeScale = 0;

            InventoryMenu.SetActive(true); // envanter on
            menuActivated = true;
        } 
    }
}
