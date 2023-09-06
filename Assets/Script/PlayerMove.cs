using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rb;
    float rotationY = 0;
    public float speedValue = 10f;
    public float rotationSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 forwardMovement = verticalInput * transform.forward;
        Vector3 rightMovement = horizontalInput * transform.right;
        Vector3 direction = (forwardMovement + rightMovement);
        direction.Normalize();

        float mouseX = Input.GetAxis("Mouse X");

        rb.AddForce(direction* speedValue);
        rotationY += (mouseX * rotationSpeed);
        transform.rotation = Quaternion.Euler(0,rotationY,0);


    }
}
