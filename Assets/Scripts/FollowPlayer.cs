using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;        //Public variable to store a reference to the player game object


    private Vector3 offset;            //Private variable to store the offset distance between the player and camera

    private Vector3 playerTransform;

    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(1.84f, -.43f, -13.7f);
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
        offset.y = -.43f; //offset.z = 0;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        Vector3 farleft = new Vector3(1.84f, -.43f, -13.7f);
        Vector3 farRight = new Vector3(34.83f, -.43f, -13.7f);
        float camerasX = transform.position.x;
        playerTransform = player.transform.position;
        if (camerasX >= 1.84f && camerasX <= 34.83f)
        {
            playerTransform.y = 0; //playerTransform.z = 0;
                                   // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
            transform.position = playerTransform + offset;
        }
        else if (camerasX < 1.84f && playerTransform.x > -1.58f)
        {
            transform.position = farleft;
        }
        else if(camerasX > 34.83f && playerTransform.x < 31.17)
        {
            transform.position = farRight;
        }
    }
}
