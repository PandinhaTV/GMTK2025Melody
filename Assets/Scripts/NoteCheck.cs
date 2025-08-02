using System;
using UnityEngine;

public class NoteCheck : MonoBehaviour
{
    public GameObject place1;
    public GameObject place2;
    public GameObject place3;
    public GameObject place4;
    public Item targetItem1;
    public Item targetItem2;
    public Item targetItem3;
    public Item targetItem4;


    

    public void CheckNotes()
    {
        foreach (Transform child in place1.transform)
        {
            InventoryItem invItem = child.GetComponent<InventoryItem>();
            if (invItem != null && invItem.item!= null && invItem.item.id == targetItem1.id)
            {
                Debug.Log("✅ Found matching item by ID!");
                return;
            }
        }

        Debug.Log("❌ targetItem is NOT a child of place1.");
    }
}
