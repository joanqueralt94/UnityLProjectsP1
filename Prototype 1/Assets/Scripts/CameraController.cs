using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Variables
    public GameObject player;
    private Vector3 offset = new Vector3 (0, 4.5f, -7);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Setting camera position on top-back of the player with an offset
        transform.position = player.transform.position + offset;
    }
}
