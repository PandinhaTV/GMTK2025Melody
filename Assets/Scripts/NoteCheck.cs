using System;
using UnityEngine;
using UnityEngine.UI;
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
    private int notecheck = 0;
    public GameObject UI;


    

    public void CheckNotes()
    {
        notecheck = 0;
        foreach (Transform child in place1.transform)
        {
            InventoryItem invItem = child.GetComponent<InventoryItem>();
            if (invItem != null && invItem.item!= null && invItem.item.id == targetItem1.id)
            {
                Debug.Log("✅ Found matching item by ID!");
                notecheck++;
                
            }
        }
        foreach (Transform child in place2.transform)
        {
            InventoryItem invItem = child.GetComponent<InventoryItem>();
            if (invItem != null && invItem.item!= null && invItem.item.id == targetItem2.id)
            {
                Debug.Log("✅ Found matching item by ID!");
                notecheck++;
                
            }
        }
        foreach (Transform child in place3.transform)
        {
            InventoryItem invItem = child.GetComponent<InventoryItem>();
            if (invItem != null && invItem.item!= null && invItem.item.id == targetItem3.id)
            {
                Debug.Log("✅ Found matching item by ID!");
                notecheck++;
                
            }
        }
        foreach (Transform child in place4.transform)
        {
            InventoryItem invItem = child.GetComponent<InventoryItem>();
            if (invItem != null && invItem.item!= null && invItem.item.id == targetItem4.id)
            {
                Debug.Log("✅ Found matching item by ID!");
                notecheck++;
                
                
            }
        }

        if (notecheck == 4)
        {
            Debug.Log("NOTE CHECKED");
            PlayMyAudio();
            //UI.SetActive(false);
            
        }
        else
        {
            Debug.Log("NOTE NOT CHECKED");
            
        }

        
        
    }
    void PlayMyAudio()
    {
        AudioSource audio = GetComponent<AudioSource>();
        if (audio != null)
        {
            audio.Play();
        }
        else
        {
            Debug.LogWarning("No AudioSource found on this GameObject!");
        }
    }
}
