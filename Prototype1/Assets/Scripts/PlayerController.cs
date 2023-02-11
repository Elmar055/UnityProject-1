using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //player speed
    public float speed = 10f; //forward speed of the car
    public float turnSpeed; //turning speed of the car
    public float horizontalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); //left and right keys
        forwardInput = Input.GetAxis("Vertical"); //forward and backward keys

        //go back and forth
        transform.Translate(Vector3.forward * Time.deltaTime*speed*forwardInput);
        //turn right left
        transform.Rotate(Vector3.up*turnSpeed * Time.deltaTime * horizontalInput);
    }
}
