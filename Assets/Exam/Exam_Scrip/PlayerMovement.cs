using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rig;
    [SerializeField] Animator _animator;
    [SerializeField] SpriteRenderer _spriteRenderer;
    [SerializeField] float _speed;

    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal") * _speed;
        float y = Input.GetAxisRaw("Vertical") * _speed;
        _rig.velocity = new Vector2(x, y);
    }

    private void Update()
    {
        if(Input.GetAxisRaw("Horizontal") < 0)
        {
            _animator.Play("WalkLeft");
        }
        if(Input.GetAxisRaw("Horizontal") > 0) 
        {
            _animator.Play("WalkRight");
        }
        if(Input.GetAxisRaw("Vertical") < 0)
        {
            _animator.Play("WalkDown");
        }
        if(Input.GetAxisRaw("Vertical") > 0)
        {
            _animator.Play("WalkUp");
        }
        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
        {
            _animator.Play("Idle");
        }
    }



}
