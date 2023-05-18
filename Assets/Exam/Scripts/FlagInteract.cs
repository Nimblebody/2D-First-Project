using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagInteract : MonoBehaviour
{
    [SerializeField] Canvas _canvas;
    SpriteRenderer _sprite;
    Animator _animator;
    Collider2D _collider;
    void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
        _collider = GetComponent<Collider2D>();
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _canvas.gameObject.SetActive(true);
    }
}
