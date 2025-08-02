using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public string objectID; // Optional: Give each object a unique name or ID
    private bool clicked;
    public void OnClick()
    { 
        PlayMyAudio();
        Debug.Log("Clicked on: " + objectID);
        
        // Example: tell a manager what was clicked
        GameManager.Instance.HandleObjectClick(this);
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