using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CameraFollow : NetworkBehaviour
{
    public Transform playerPosition;
    public Transform cameraPosition;

    void FixedUpdate()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        var distance = playerPosition.position - cameraPosition.position;
        distance.z = 0;
        cameraPosition.Translate(distance * (Time.fixedDeltaTime * 10));
    }
}
