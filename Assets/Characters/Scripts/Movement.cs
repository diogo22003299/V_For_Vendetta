using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float runmodifier;
    private Rigidbody2D rb;
    private float moveH;
    private Animator animator;
    private SpriteRenderer spriteRender;
    
    private MoveDirection direction;

    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRender = GetComponent<SpriteRenderer>();
        direction = MoveDirection.Right;
    }

    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * (Input.GetKey(KeyCode.LeftShift) ? runmodifier : moveSpeed), rb.velocity.y);

        if (rb.velocity.x > 0) 
        {
            direction = MoveDirection.Right;
        }
        else if (rb.velocity.x < 0) 
        {
            direction = MoveDirection.Left;
        }

        animator.SetBool("IsWalking", rb.velocity.x != 0);
        spriteRender.flipX = direction == MoveDirection.Right ? true : false;
    }
    
}

public enum MoveDirection 
{
    Right,
    Left
}