using System;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public string objectID; // Optional: Give each object a unique name or ID
    private bool clicked;
    private Animator animator;
    private string animationName;
    private void Start()
    {
        GetComponent<Animator>().enabled = false;
        animator = GetComponent<Animator>();
        animationName = gameObject.name;
        
        animator = GetComponent<Animator>();

        // Automatically get first state name from the AnimatorController
        RuntimeAnimatorController rac = animator.runtimeAnimatorController;
        if (rac.animationClips.Length > 0)
        {
            animationName = rac.animationClips[0].name;
        }
        else
        {
            Debug.LogWarning($"No animation clips found on {gameObject.name}");
        }
    }

    public void OnClick()
    { 
        PlayMyAudio();
        Debug.Log("Clicked on: " + objectID);
        if (!string.IsNullOrEmpty(animationName))
        {
            animator.Play(animationName, 0, 0f);
        }
        // Example: tell a manager what was clicked
        GameManager.Instance.HandleObjectClick(this);
    }
    void PlayMyAudio()
    {
        AudioSource audio = GetComponent<AudioSource>();
        if (audio != null)
        {
            audio.Play();
            GetComponent<Animator>().enabled = true;
            
        }
        else
        {
            Debug.LogWarning("No AudioSource found on this GameObject!");
        }
    }
  
}