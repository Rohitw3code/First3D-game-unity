using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float farwordForce = 700f;
    public float sideForce = 100f;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start(){    
    }

    // Update is called once per frame
    // All physics attributes are added in 'FixedUpdate'
    void FixedUpdate()
    {
        if ( Input.GetKey(KeyCode.A)) {
            rb.AddForce(-sideForce * Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.D)){
            rb.AddForce(sideForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W)){
            rb.AddForce(0,0, farwordForce * Time.deltaTime);
//            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
}
