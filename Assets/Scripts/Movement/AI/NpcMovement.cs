using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NpcMovement : MonoBehaviour
{
    [SerializeField] Transform[] _points;
    [SerializeField] Transform _hero;
    Transform _slime;
    [SerializeField] float _speed;
    SpriteRenderer _spriteRenderer;
    int _nowTime = 0;
    //Normalize -> ���Ⱚ���� �����´�
    //�������� ���� ���� �׷� ���������� �Ÿ��� ���� ���Ⱚ�� ��µǵ��� �Ѵ�.
    private void Start()
    {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        _slime = GetComponent<Transform>();
        Debug.Log($"Slime Component's : {transform.position}");
        Debug.Log($"Gameobject's Name: {gameObject}");
    }
    public void Initialize(Transform[] points, Transform hero)
    {
        _points = points;
        _hero = hero;
    }

    private void Update()
    {
        if(Vector3.Distance(_hero.position, _slime.position) < 3f)
        {
            FollowHero();
        }
        else
        {
            Patrol();
        }
        if (Input.GetMouseButtonDown(0))
        {
            _spriteRenderer.flipX = true;
        }
        if (Input.GetMouseButtonDown(1))
        {
            _spriteRenderer.flipX = false;
        }
        
        
    }

    
    void Patrol()
    {
        Vector3 nextPosition = _points[_nowTime].position;
        Vector3 moveVector = (nextPosition - _slime.position);
        Vector3 dirVector = moveVector.normalized;                  
        Vector3 speedVector = dirVector * _speed;
        _slime.position = _slime.position + speedVector * Time.deltaTime;

        if(Vector3.Distance(_slime.position, nextPosition) < 0.11f)
        {
            _nowTime++;
            if(_nowTime >= _points.Length)
            {
                _nowTime = 0;
            }
        }
    }
    void FollowHero()
    {
        Vector3 moveVector = (_hero.position - _slime.position);    //����� ũ�⸦ ����
        Vector3 dirVector = moveVector.normalized;                  //���Ⱚ ���� ����   
        Vector3 speedVector = dirVector * _speed;
        _slime.position = _slime.position + speedVector * Time.deltaTime;
    }
}
