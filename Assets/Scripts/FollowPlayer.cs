using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    void Start()
    {
        // Finds the difference between the starting positions of camera and player and sets as the offset
        offset = (transform.position-player.transform.position);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Maintains the offset of the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
    }
}
