using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float horsePower = 100;
    [SerializeField] float turnSpeed = 40.0f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody rb;
    [SerializeField] GameObject centreOfMass;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = centreOfMass.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // Move the vehicle forward based on vertical input
        rb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
        // Rotate the vehicle based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
