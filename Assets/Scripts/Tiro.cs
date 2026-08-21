using System;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _ySpeed=100;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb.AddForceY(_ySpeed, ForceMode2D.Force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
