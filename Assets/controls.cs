using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class controls : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 10;

    public Vector3 jump;
    public float jumpForce = 2.0f;

    public bool isGrounded;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.A)) {
            transform.Translate (Vector3.left * speed * Time.deltaTime); 
        }
        if(Input.GetKey (KeyCode.D)) {
            transform.Translate (Vector3.right * speed * Time.deltaTime);
        }
        if(Input.GetKey (KeyCode.W)) {
            transform.Translate (Vector3.forward * speed * Time.deltaTime);
        }
        if(Input.GetKey (KeyCode.S)) {
            transform.Translate (Vector3.back * speed * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded){

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionStay(){
        isGrounded = true;
    }
}
