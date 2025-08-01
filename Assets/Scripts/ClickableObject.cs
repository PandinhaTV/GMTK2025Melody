using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public string objectID; // Optional: Give each object a unique name or ID

    public void OnClick()
    {
        Debug.Log("Clicked on: " + objectID);

        // Example: tell a manager what was clicked
        GameManager.Instance.HandleObjectClick(this);
    }
}