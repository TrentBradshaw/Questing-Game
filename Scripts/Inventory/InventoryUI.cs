using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Transform itemsParent;  //get the itemsParent
    public GameObject inventoryUI;

    Inventory inventory;  // reference the player's inventory
    InventorySlot[] slots; //create an array named slots
    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.instance;  //inventory is set as the instance of our inventory
        inventory.onItemChangedCallback += UpdateUI;  //load UpdateUI to the delegate's list
        slots = itemsParent.GetComponentsInChildren<InventorySlot>();  //slots is set to the items in the itemsParent list which is an array of all of the item slots
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);
        }
    }
    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)  
        {
            if(i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}
