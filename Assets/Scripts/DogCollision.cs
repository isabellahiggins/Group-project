using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogCollision : MonoBehaviour
{
    // Respawn position for dog
    private Vector3 startingPosition = new Vector3(-587, 1, 139);
    // Camera position
    public Transform cameraTransform;

    public GameManager gameManager; // Reference to GameManager to call GameRestart

    private void OnTriggerEnter(Collider other)
    {
        // Only respawn the dog when he hits the obstacle
        if (other.CompareTag("Obstacle"))
        {
            // Set him back to the starting position if he hits the obstacle
            transform.position = startingPosition;

            // Call GameRestart to show "Game Restart" text
            gameManager.GameOver();  // Call to show the "Game Restart" text

            // Adjust the camera position to look at the dog
            if (cameraTransform != null)
            {
                cameraTransform.LookAt(transform);
            }
        }
    }
}

