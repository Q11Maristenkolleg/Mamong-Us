using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerControls : MonoBehaviour
{
    [FormerlySerializedAs("SPEED")] public float speed = 10f;
    private Transform _transform;
    
    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 
            Input.GetAxis("Vertical") * Time.deltaTime * speed, 0);
    }
}
