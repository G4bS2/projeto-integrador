using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    void Start() {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        // Captura movimento
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Define parâmetros para o Animator
        animator.SetFloat("MoveX", movement.x);
        animator.SetFloat("MoveY", movement.y);
        animator.SetBool("IsMoving", movement != Vector2.zero);

        if (movement != Vector2.zero)
{
    animator.SetFloat("LastMoveX", movement.x);
    animator.SetFloat("LastMoveY", movement.y);
}
    }

    void FixedUpdate()
    {
        // Movimento do Rigidbody
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
