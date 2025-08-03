using UnityEngine;

public class SpriteBillboard : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Camera.main.transform.position - transform.position;
        direction.x = direction.z = 0; // Keep only y-axis rotation
        transform.LookAt(-Camera.main.transform.position - direction);

    }
}
