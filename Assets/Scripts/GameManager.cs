using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public InventoryManager inventoryManager;
    public Item[] itemsToPickup;

    private void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log("Clicked: " + hit.collider.gameObject.name);

                // Optional: call method on custom script
                var clickable = hit.collider.GetComponent<ClickableObject>();
                if (clickable != null)
                {
                    clickable.OnClick();
                }
            }
        }
    }


    // ReSharper disable Unity.PerformanceAnalysis
    public void HandleObjectClick(ClickableObject obj)
    {
        switch (obj.objectID)
        {
            case "Bird":
                Debug.Log("You clicked Bird!");
                PickupItem(0);
                break;
            case "Chimes":
                Debug.Log("You clicked Chimes!");
                PickupItem(1);
                break;
            case "Dog":
                Debug.Log("You clicked Dog!!");
                PickupItem(2);
                break;
            case "Frog":
                Debug.Log("You clicked Frog!");
                PickupItem(3);
                break;
            case "Zap":
                Debug.Log("You clicked Zap");
                PickupItem(0);
                break;
            case "Pipe":
                Debug.Log("You clicked Pipe");
                PickupItem(1);
                break;
            case "Rat":
                Debug.Log("You clicked Rat");
                PickupItem(2);
                break;
            case "Can":
                Debug.Log("You clicked Can");
                PickupItem(3);
                break;

            default:
                Debug.Log("Clicked: " + obj.name);
                break;
        }
    }

    public void PickupItem(int id)
    {
        inventoryManager.AddItem(itemsToPickup[id]);
    }
}