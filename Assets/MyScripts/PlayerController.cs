using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; // Player Movement Speed
    public float rotationSpeed = 120.0f; // Player Rotation Speed

    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Access player's Rigidbody
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Handle physics-based movement and rotaion.
    private void FixedUpdate()
    {
        // Move player based on vertical input.
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * moveVertical * speed* Time.deltaTime;
        rb.MovePosition(rb.position + movement);

        // Rotate player based on horizontal input.
        float turn = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);



    }
}
