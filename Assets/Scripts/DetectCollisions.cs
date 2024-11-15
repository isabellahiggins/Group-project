using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public GameManager gameManager;

    //Strawberry disappears when dog hits it
    private void OnTriggerEnter(Collider other){
        //Score updates when a strawberry is collected
        gameManager.UpdateScore(5);
        Destroy(gameObject);
    }
}
