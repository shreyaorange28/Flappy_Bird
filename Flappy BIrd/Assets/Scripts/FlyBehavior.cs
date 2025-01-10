using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlyBehavior : MonoBehaviour
{
    [SerializeField] private float _velocity = 1.5f;
    //[SerializeField] private float _rotationSpeed = 10f;

    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //if (Mouse.current.leftButton.wasPressedThisFrame)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.linearVelocity = Vector2.up * _velocity;
        }
    }
}
