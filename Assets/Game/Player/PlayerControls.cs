using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Serialization;

public class PlayerControls : /*MonoBehaviour*/NetworkBehaviour
{
    public float speed = 10f;
    
    private readonly Vector3 Y_AXIS = new Vector3(0, 1, 0);

    public new Transform transform;
    public new Rigidbody2D rigidbody;
    public Animator animator;
    
    private Vector2 _move;
    private bool _left;

    void Update()
    {
        if (!this.isLocalPlayer)
        {
            return;
        }
        _move.x = Input.GetAxis("Horizontal");
        _move.y = Input.GetAxis("Vertical");
        var mm = _move.sqrMagnitude;
        animator.SetFloat("speed", mm);
        if (mm < 0.1)
        {
            return;
        }
        if (mm > 1)
        {
            _move.Normalize();
        }
        if (_move.x == 0)
        {
            return;
        }
        if (_left ^ _move.x < 0)
        {
            _left = !_left;
            transform.Rotate(Y_AXIS, 180);
            //transform.localScale = new Vector3(_move.x < 0 ? -1 : 1, 1, 1);
        }
    }

    void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + _move * (Time.fixedDeltaTime * speed));
    }
}
