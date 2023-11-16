using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncomingVehicle : MonoBehaviour
{
    private float vehicleSpeed = 9.0f;
   

    // Update is called once per frame
    void Update()
    {
        // Moves the vehicle forward over time
        transform.Translate(Vector3.forward * vehicleSpeed * Time.deltaTime);
    }
}
