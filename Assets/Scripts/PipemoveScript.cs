using UnityEngine;

public class PipemoveScript : MonoBehaviour
{
    public float moveSpeed = 2f; // Speed at which the pipe moves
                                 // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float deadZone = -10f; // X position at which the pipe is considered off-screen
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * moveSpeed; // Move the pipe to the left at a speed of 2 units per second
        if (transform.position.x < deadZone) // Check if the pipe has moved off-screen
        {
            Debug.Log("Pipe destroyed"); // Log a message for debugging
            Destroy(gameObject); // Destroy the pipe if it is no longer visible
        }
    }
}
