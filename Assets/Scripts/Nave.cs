using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Nave : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _xDir; 
    [SerializeField] GameObject tiroPrefab;
    
    [SerializeField] private float xSpeed;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Movimentar()
    {
        //aplicar moviemento do corpo rigido
        _rb.linearVelocityX = _xDir * xSpeed;
        print("Direção: " + _xDir);
        
    }



    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        Movimentar();
    }

    //chamado pelo player input
    void OnMove(InputValue inputValue)
    {
        _xDir = inputValue.Get<Vector2>().x;
    }

    void OnAttack()
    {

        Instantiate( tiroPrefab,transform.position ,Quaternion.identity);

    }
}
