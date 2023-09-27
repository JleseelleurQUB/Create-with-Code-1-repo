using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public GameObject playerView;

    // Update is called once per frame
    void Update()
    {
        // Switches between cameras when corresponding keys "1" and "2" are pressed
        if (Input.GetKeyDown("2")) 
            playerView.SetActive(false);

        if (Input.GetKeyDown("1"))
            playerView.SetActive(true);
        
    }
}
