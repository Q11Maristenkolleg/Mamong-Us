using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerControls : MonoBehaviour
{
    public float speed = 10f;

    public Transform transform;
    public Rigidbody2D rigidbody;
    public Animator animator;
    
    private Vector2 _move;
    private bool _left;

    void Update()
    {
        _move.x = Input.GetAxis("Horizontal");
        _move.y = Input.GetAxis("Vertical");
        animator.SetFloat("speed", _move.sqrMagnitude);
        if (_move.x == 0)
        {
            return;
        }
        if (_left ^ _move.x < 0)
        {
            _left = !_left;
            transform.localScale = new Vector3(_move.x < 0 ? -1 : 1, 1, 1);
        }
    }

    void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + _move * (Time.fixedDeltaTime * speed));
    }
}
