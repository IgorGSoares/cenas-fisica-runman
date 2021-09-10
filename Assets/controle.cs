using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controle : MonoBehaviour
{
    // private Vector3 movevector;
    // private Vector3 lastmove;
    // private float speed = 8;
    // private float jumpforce = 8;
    // private float gravity = 25;
    // private float verticalvelocity;
    // private CharacterController controler;

    void Start()
    {
        // controler = this.GetComponent<CharacterController>();
    }

    
    void Update()
    {
        // movevector = Vector3.zero;
        // movevector.x = InputManager.MainHorizontal();
        // movevector.y = InputManager.MainVertical();

        // if (controler.isGrounded)
        // {
        //     verticalvelocity = -1;
        //     if (InputManager.AButton())
        //     {
        //         verticalvelocity = jumpforce;
        //     }
        //     else
        //     {
        //         verticalvelocity -= gravity*Time.deltaTime;
        //         movevector = lastmove;
        //     }

        //     movevector.y = 0;
        //     movevector.Normalize();
        //     movevector*=speed;
        //     movevector.y = verticalvelocity;

        //     controler.Move(movevector*Time.deltaTime);
        //     lastmove = movevector;
        // }
    }
}
