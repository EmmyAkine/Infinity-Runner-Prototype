using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sideWaysForce = 500f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce( sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce( -sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
    public void StopPlayer()
    {
        rb.velocity = Vector3.zero;
    }
   
}
