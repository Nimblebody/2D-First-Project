using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment_Final : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rig;
    [SerializeField] Animator _animator;
    [SerializeField] SpriteRenderer _spriteRenderer;
    [SerializeField] float _speed;

    bool _isGround = false;
    int jumpCount = 0;
    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal") * _speed;
        _rig.velocity = new Vector2(x, _rig.velocity.y);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && (_isGround == true || jumpCount < 2))
        {
            _animator.SetBool("isJump", true);
            jumpCount++;
            _isGround = false;
            _rig.AddForce(Vector2.up * 7, ForceMode2D.Impulse);
            
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            _spriteRenderer.flipX = true;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            _spriteRenderer.flipX = false;
        }
        
        
        if (_isGround == false)
        {
            //_animator.SetBool("isJump", true);
            //_animator.SetBool("isRun", false);
            _animator.Play("Jump_Animation");
        }else if(_rig.velocity != Vector2.zero)
        {
            //_animator.SetBool("isJump", false);
            //_animator.SetBool("isRun", true);
            _animator.Play("Run_Animation");
        }
        else
        {
            //_animator.SetBool("isJump", false);
            //_animator.SetBool("isRun", false);
            _animator.Play("Idle_Animation");
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.name == "GroundBase")
        {
            _animator.SetBool("isJump", false);
            _isGround = true;
            jumpCount = 0;
        }


    }
}
