using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ExamGameObject : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    //좌클릭 위, 우클릭 오른쪽
    GameObject _lastObject;
    int _countUp = 0 , _countLeft =0;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject gameObject = Instantiate(_prefab,new Vector3(_countLeft,_countUp++,0),Quaternion.identity,transform);
            //Transform tr = gameObject.transform;
            //tr.position = new Vector3(_countLeft, _countUp, 0);
            //++_countUp;
            _lastObject = gameObject;
        }
        if (Input.GetMouseButtonDown(1))
        {
            GameObject gameObject = Instantiate(_prefab,transform);
            Transform tr = gameObject.transform;
            tr.position = new Vector3(_countLeft, _countUp, 0);
            --_countLeft;
            _lastObject = gameObject;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Destroy(_lastObject);
            //SpriteRenderer sr = _lastObject.GetComponent<SpriteRenderer>();
            //Destroy(_lastObject);
        }
    }

}
