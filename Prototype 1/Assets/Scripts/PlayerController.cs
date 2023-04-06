using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CameraController cameraMain;

    //Private variables
    private float Speed = 20.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Saving the input from the player with Left or Right
        horizontalInput = Input.GetAxis("Horizontal");

        //Saving the input from the player with Up or Down
        verticalInput = Input.GetAxis("Vertical");

        //Move Truck Forward
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * verticalInput);
        //Move Truck Sideways
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        //Moving 1st person camera with rotation too
        if(cameraMain.cameraSwap)
        {
            cameraMain.transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        }
        
        if (Input.GetKeyDown(KeyCode.C))
        {
            //print("Player has pressed C button");
            if (!cameraMain.cameraSwap)
            {
                cameraMain.cameraSwap = true;
            }
            else
            {
                cameraMain.cameraSwap = false;  
            }
        }        
    }
}
