using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;

    // Set an offset to place the camera behind and above the player
    private Vector3 offset = new Vector3(0, 5, -10);

    void Start()
    {
        // Initialize the offset based on the camera's initial position relative to the player
        offset = transform.position - Player.transform.position;
    }

    void Update()
    {
        // Move the camera to follow the player with the offset
        transform.position = Player.transform.position + offset;
        
        // Make the camera look down at the player
        transform.LookAt(Player.transform.position + Vector3.up * 2.5f); // Adjust '1.5f' for a higher or lower look-at point
    }
}
