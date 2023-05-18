using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeFollow : MonoBehaviour
{
    [SerializeField] Transform[] _points;
    [SerializeField] Transform _player;
    Transform _slime;
    [SerializeField] float _speed;
    SpriteRenderer _spriteRenderer;
    int _nowTime = 0;
    //Normalize -> 방향값만을 가져온다
    //중점으로 부터 원을 그려 반지름값을 거리로 가진 방향값이 출력되도록 한다.
    private void Start()
    {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        _slime = GetComponent<Transform>();
        
    }


    private void Update()
    {
        if (Vector3.Distance(_player.position, _slime.position) < 5f)
        {
            FollowHero();
        }
        else
        {
            Patrol();
        }
        


    }


    void Patrol()
    {
        Vector3 nextPosition = _points[_nowTime].position;
        Vector3 moveVector = (nextPosition - _slime.position);
        Vector3 dirVector = moveVector.normalized;
        Vector3 speedVector = dirVector * _speed;
        _slime.position = _slime.position + speedVector * Time.deltaTime;

        if (Vector3.Distance(_slime.position, nextPosition) < 0.11f)
        {
            _nowTime++;
            if (_nowTime >= _points.Length)
            {
                _nowTime = 0;
            }
        }
    }
    void FollowHero()
    {
        Vector3 moveVector = (_player.position - _slime.position);    //방향과 크기를 가짐
        Vector3 dirVector = moveVector.normalized;                  //방향값 만을 가짐   
        Vector3 speedVector = dirVector * _speed;
        _slime.position = _slime.position + speedVector * Time.deltaTime;
    }
}
