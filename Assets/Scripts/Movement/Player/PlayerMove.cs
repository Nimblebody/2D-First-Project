using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rigid;
    [SerializeField] Animator _animator;
    [SerializeField] SpriteRenderer _spriteRenderer;
    int jumpCount = 0;
    bool isOnFloor = false;
    private void FixedUpdate()//even method called before physics calculation
    {
        float y = Input.GetAxisRaw("Jump");
        float x = Input.GetAxisRaw("Horizontal");
        _rigid.velocity = new Vector2(x * 9, _rigid.velocity.y);

    }

    private void Update()
    {
        float MovmentSpeed = Input.GetAxisRaw("Horizontal") * 9;
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            _spriteRenderer.flipX = true;
        }
        else if(Input.GetAxisRaw("Horizontal") > 0)
        {
            _spriteRenderer.flipX = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && (jumpCount < 3 && isOnFloor == true))
        {
            _animator.SetBool("isJump", true);
            _animator.SetBool("isRun", false);
            jumpCount++;
            _rigid.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            _animator.SetBool("isRun", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _animator.SetBool("isRun", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            _animator.SetBool("isRun", false);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            _animator.SetBool("isRun", false);
        }
        if(jumpCount == 3)
        {
            isOnFloor = false;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collison on : " + collision.collider.name);
        
        if(collision.collider.CompareTag("Jumping"))
        {
            _animator.SetBool("isJump", false);
            isOnFloor = true;
            jumpCount = 0;
        }
        
        
    }

}
