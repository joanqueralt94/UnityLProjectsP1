using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Variables
    public GameObject player;
    private Vector3 offsetCamera1 = new Vector3 (0, 4.5f, -7f);
    private Vector3 offsetCamera2 = new Vector3(0, 2.5f, 0.5f);

    public bool cameraSwap = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!cameraSwap)
        {
            //Setting camera position on top-back of the player with an offset
            transform.position = player.transform.position + offsetCamera1;
        }
        else
        {
            //Setting camera position on top-back of the player with an offset
            transform.position = player.transform.position + offsetCamera2;
        }
    }
}
