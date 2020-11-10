using System;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public PlayerControls player;
    private Transform _transform;
    private Vector3 _distance;
    
    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _distance = player.GetPosition() - _transform.position;
        _distance.z = 0;
        _transform.Translate(_distance);
    }
}
