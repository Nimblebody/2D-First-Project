using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NpcMovement : MonoBehaviour
{
    [SerializeField] Transform[] _points;
    [SerializeField] Transform _hero;
    [SerializeField] Transform _slime;
    [SerializeField] float _speed;

    int _nowTime = 0;
    //Normalize -> ���Ⱚ���� �����´�
    //�������� ���� ���� �׷� ���������� �Ÿ��� ���� ���Ⱚ�� ��µǵ��� �Ѵ�.
    private void Update()
    {
        Patrol();
        
    }
    void Patrol()
    {
        Vector3 nextPosition = _points[0].position;
        Vector3 moveVector = (nextPosition - _slime.position);
        Vector3 dirVector = moveVector.normalized;                  
        Vector3 speedVector = dirVector * _speed;
        _slime.position = _slime.position - speedVector * Time.deltaTime;

        if(Vector3.Distance(_slime.position, nextPosition) < 0.11)
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
        _slime.position = _slime.position - speedVector * Time.deltaTime;
    }
}
