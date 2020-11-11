using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerPosition;
    public Transform cameraPosition;

    void FixedUpdate()
    {
        var distance = playerPosition.position - cameraPosition.position;
        distance.z = 0;
        cameraPosition.Translate(distance * (Time.fixedDeltaTime * 4));
    }
}
