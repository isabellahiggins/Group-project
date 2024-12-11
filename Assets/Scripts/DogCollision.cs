
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogCollision : MonoBehaviour
{
    //Respawn position for dog
    private Vector3 startingPosition = new Vector3(-587, 1, 139);
    //camera position
    public Transform cameraTransform;

    private void OnTriggerEnter(Collider other)
    {
        //Only respawn the dog when he hits the logs
        if(other.CompareTag("Obstacle")){
        // Set him back to starting position if hits log
        transform.position = startingPosition;

        // Camera position
        if (cameraTransform != null)
        {
            cameraTransform.LookAt(transform);
        }
        }
    }
}
