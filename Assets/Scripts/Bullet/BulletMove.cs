using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    Vector3 _direction;
    float _speed;
    float _time;

    public void Init(Vector3 dir, float speed)
    {
        _direction = dir;
        _speed = speed;
        Destroy(gameObject, 2f);
    }

    private void Update()
    {
        transform.position += _direction * Time.deltaTime * _speed;
        //_time += Time.deltaTime;
        //if (_time > 2)
        //{
        //    Destroy(gameObject);
        //}
        //Invoke("DeleteBullet", 2f); 정해진 시간마다 함수호출
    }

    void DeleteBullet()
    {
        Destroy(gameObject);
    }
}
