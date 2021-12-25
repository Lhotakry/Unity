using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float movingForce = 500f;
    float xInput;
    float zInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        rb.AddForce(xInput * movingForce, 0, zInput * movingForce);
        /*//moving to the right
        if(Input.GetAxis("Horizontal") > 0)
        {
            rb.AddForce(movingForce, 0, 0);
        }

        //moving to the left
        if(Input.GetAxis("Horizontal") < 0)
        {
            rb.AddForce(-movingForce, 0, 0);
        }

        //moving forward
        if(Input.GetAxis("Vertical") > 0)
        {
            rb.AddForce(0, 0, movingForce);
        }
        
        //moving backward
        if(Input.GetAxis("Vertical") < 0)
        {
            rb.AddForce(0, 0, -movingForce);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, jumpForce, 0);
        }*/
        
    }
}
