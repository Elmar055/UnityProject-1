using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //The player object in the game
    public GameObject player;


    public Vector3 offset = new Vector3(0, 8, -12);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Move the camera position away from the player
        transform.position = player.transform.position + offset;
    }
}
