using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public float velocidade = 5f;
    private Vector2 direcao;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Pegando a entrada do teclado
        direcao.x = Input.GetAxisRaw("Horizontal"); // A/D ou ? ?
        direcao.y = Input.GetAxisRaw("Vertical");   // W/S ou ? ?
        direcao.Normalize(); // Garante velocidade constante em diagonal
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + direcao * velocidade * Time.fixedDeltaTime);
    }
}
