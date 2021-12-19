using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Move : MonoBehaviour
{   
    public Rigidbody rb;
    private float ForwardForce = 50.0f;
    private float SideForce = 45.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,ForwardForce*Time.deltaTime);


        if (Input.GetKey("LeftArrow"))
        {
            rb.AddForce(SideForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("RightArrow"))
        {
            rb.AddForce(-SideForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
    }
}
