using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeGameObject : MonoBehaviour
{
    [SerializeField] Sprite _setSprite;
    [SerializeField] GameObject _myPrefab;
    GameObject _lastObj;
    int _count = 0;

    private void Start()
    {
        
    }
    void Update(){
        if(Input.GetMouseButtonDown(0)){
            //new GameObject(); //새로운 object 생성
            GameObject gameObj = new GameObject();
            gameObj.AddComponent<SpriteRenderer>();
            SpriteRenderer _sprite = gameObj.GetComponent<SpriteRenderer>();
            _sprite.sprite = _setSprite;
            //Object 생성 위치 +1씩 이동
            Transform _transform = gameObj.GetComponent<Transform>();
            _transform.position = new Vector3(_count , 0, 0);
            _count++;
        }
        if(Input.GetMouseButtonDown(1)){
            GameObject gameObj = Instantiate(_myPrefab,new Vector3(_count,0,0),Quaternion.identity);//transform이라 넣어주면 해당 오브젝트의 자식오브젝트로 생성
            gameObj.transform.SetParent(transform); //해당 오브젝트의 transfrom을 부모로 지정
            //gameObj.transform.position = new Vector3(_count,0,0);
            _count++;
            _lastObj = gameObj;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Destroy(_lastObj);
            //SpriteRenderer sr =_lastObj.GetComponent<SpriteRenderer>();
            //Destroy(sr);
        }
    }
}
