using UnityEngine;
using UnityEngine.InputSystem;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public InventoryManager inventoryManager;
    public Item[] itemsToPickup;
    void Awake()
    {
        Instance = this;
    }

    void Update()
    {
       if (Mouse.current.leftButton.wasPressedThisFrame)
           {
               Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
               if (Physics.Raycast(ray, out RaycastHit hit))
               {
                   Debug.Log("Clicked: " + hit.collider.gameObject.name);
       
                   // Optional: Get a script on the clicked object
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
            case "Tile1":
                Debug.Log("You clicked Tile 1!");
				PickupItem(0);
                break;
            case "Tile2":
                Debug.Log("You clicked Tile 2!");
                break;
            case "Enemy":
                Debug.Log("That’s an enemy!");
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
