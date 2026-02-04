using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
   
    void Update()
    {
        //Move the vehicle forward
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Moves the car forward based on vertical Input.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the car based on horizontall input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
