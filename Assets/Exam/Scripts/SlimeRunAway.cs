using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeRunAway : MonoBehaviour
{
    [SerializeField] Transform[] _points;
    [SerializeField] Transform _player;
    [SerializeField] float _speed;

    Transform _slime;
    SpriteRenderer _sprite;

    int _nowTime = 0;
    void Start()
    {
        _slime = GetComponent<Transform>();
        _sprite = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        if (Vector3.Distance(_player.position, _slime.position) < 5f)
        {
            RunFromHero();
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
    void RunFromHero()
    {
        Vector3 moveVector = (_player.position - _slime.position);
        Vector3 dirVector = moveVector.normalized;                     
        Vector3 speedVector = dirVector * _speed;
        _slime.position = _slime.position - speedVector * Time.deltaTime;
    }
}
