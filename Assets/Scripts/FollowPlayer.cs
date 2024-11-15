using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;

    // Co-ords of camera
    private Vector3 offset = new Vector3(0, 5, -10);

    void Start()
    {
        //distance between the dog and camera
        offset = transform.position - Player.transform.position;
    }

    void Update()
    {
        // Follow player aswell as keeping distance
        transform.position = Player.transform.position + offset;
        
        //Rotate to look down on dog
        transform.LookAt(Player.transform.position + Vector3.up * 2.5f);
    }
}
