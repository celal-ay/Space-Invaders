using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    
    public GameObject InventoryMenu; // atanacak obje.
    private bool menuActivated; // flag
    public ItemSlot[] itemSlot;

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

    public void AddItem(string itemName, int quantity, Sprite itemSprite)
    {
        for(int i = 0; i < itemSlot.Length; i++)
        {
            if (itemSlot[i].isFull == false)
            {
                itemSlot[i].AddItem(itemName, quantity, itemSprite);
                return;
            }
        }
    }
}
