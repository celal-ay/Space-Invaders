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
        if (Input.GetKeyDown(KeyCode.E) && menuActivated) // menü aktifse ve kullanýcý e ye basmýþsa atanmýþ objeyi deaktive et.
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
