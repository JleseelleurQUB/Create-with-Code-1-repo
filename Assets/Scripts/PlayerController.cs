using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float horsePower = 100;
    [SerializeField] float speed;
    [SerializeField] float turnSpeed = 40.0f;
    [SerializeField] float rpm;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody rb;
    [SerializeField] GameObject centreOfMass;
    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] TextMeshProUGUI rpmText;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = centreOfMass.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // Update the speedometer and rpm
        speed = Mathf.RoundToInt(rb.velocity.magnitude * 3.6f);
        speedometerText.SetText("Speed: " + speed + "km/h");
        rpm = Mathf.RoundToInt((speed % 30) * 40);
        rpmText.SetText("RPM: " + rpm);


        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the vehicle forward based on vertical input
        if (speed < 100)
        {
            rb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
        }

        // Rotate the vehicle based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        // Slow the vehicle when player is no longer pressing forward
        if(horizontalInput == 0 && speed > 0)
        {
            rb.AddRelativeForce(Vector3.forward * -4000);
        }

    }
}
