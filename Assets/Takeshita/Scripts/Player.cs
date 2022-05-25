using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField, Tooltip("移動速度")]
        float _moveSpeed;

    private Rigidbody2D _rb;
    private int _dir;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _dir = (Input.GetKey(KeyCode.W) ? 1 : 0) + (Input.GetKey(KeyCode.S) ? -1 : 0);
    }

    private void FixedUpdate()
    {
        _rb.velocity = Vector3.up * _dir * _moveSpeed;
    }
}
