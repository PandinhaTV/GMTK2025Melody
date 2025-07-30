using UnityEngine;
using UnityEngine.InputSystem;

public class CameraScroll : MonoBehaviour
{
    public float scrollSpeed = 10f;
    public float edgeSize = 20f; // in pixels
    public float minX = -50f, maxX = 50f;
    public float minY = -50f, maxY = 50f;

    void Update()
    {
        Vector3 move = Vector3.zero;
        Vector2 mousePos = Mouse.current.position.ReadValue();


        if (mousePos.x < edgeSize)
            move.x = -1;
        else if (mousePos.x > Screen.width - edgeSize)
            move.x = 1;

        if (mousePos.y < edgeSize)
            move.y = -1;
        else if (mousePos.y > Screen.height - edgeSize)
            move.y = 1;

        transform.position += move * scrollSpeed * Time.deltaTime;

        // Clamp camera within bounds
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, minX, maxX),
            Mathf.Clamp(transform.position.y, minY, maxY),transform.position.z
            
        );
    }
}