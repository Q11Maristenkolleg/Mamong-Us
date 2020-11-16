using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Networking;

public class NetworkEnable : NetworkBehaviour
{
    void Start()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        GetComponent<PlayerControls>().enabled = true;
        GetComponent<CameraFollow>().enabled = true;
        if (Camera.main != null)
        {
            GetComponent<CameraFollow>().cameraPosition = Camera.main.GetComponent<Transform>();
        }
        GetComponent<BoxCollider2D>().enabled = true;
        GetComponent<Light2D>().enabled = true;
    }
}
