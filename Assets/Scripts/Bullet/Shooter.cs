using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject Bullet;
    [SerializeField] float _speed;
    float _time;
    float _degree;
    float _degree2 = 10;
    bool check = false;
    private void Update()
    {
        _degree += 30 * Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
        {
            GameObject temp = Instantiate(Bullet);
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
            {
                temp.GetComponent<BulletMove>().Init(new Vector3(1, 1, 0).normalized, _speed);
                Debug.Log(new Vector3(1,1,0).normalized);
            }
            else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
            {
                temp.GetComponent<BulletMove>().Init(new Vector3(-1, 1, 0).normalized, _speed);
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
            {
                temp.GetComponent<BulletMove>().Init(new Vector3(1, -1, 0).normalized, _speed);
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            {
                temp.GetComponent<BulletMove>().Init(new Vector3(-1, -1, 0).normalized, _speed);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                temp.GetComponent<BulletMove>().Init(Vector3.right,_speed);
            }
            else if(Input.GetKey(KeyCode.W)) 
            {
                temp.GetComponent<BulletMove>().Init(Vector3.up, _speed);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                temp.GetComponent<BulletMove>().Init(Vector3.down, _speed);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                temp.GetComponent<BulletMove>().Init(Vector3.left, _speed);
            }
            else
            {
                
                float x = Mathf.Cos(_degree * Mathf.Deg2Rad); //x값  
                float y = Mathf.Sin(_degree * Mathf.Deg2Rad); //y값
                
                temp.GetComponent<BulletMove>().Init(new Vector3(x, y, 0).normalized, _speed);
                
            }
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
          
            for (int i = 0; i < 12; i++)
            {
                GameObject temp = Instantiate(Bullet);
                float x = Mathf.Cos(_degree2 * Mathf.Deg2Rad); //x값  
                float y = Mathf.Sin(_degree2 * Mathf.Deg2Rad); //y값
                temp.GetComponent<BulletMove>().Init(new Vector3(x, y, 0).normalized, _speed);
                _degree2 += 10;
            }
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            StartCoroutine(DelayTime());
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            for(int i = 0;i < 12; i++)
            {
                Invoke("MakeBullet", 0.1f * i);
            }
            
        }
        // acrtan = 각도 -> result: radian

    }

    void MakeBullet()
    {
        GameObject temp = Instantiate(Bullet);
        float x = Mathf.Cos(_degree2 * Mathf.Deg2Rad); //x값  
        float y = Mathf.Sin(_degree2 * Mathf.Deg2Rad); //y값
        temp.GetComponent<BulletMove>().Init(new Vector3(x, y, 0).normalized, _speed);
        _degree2 += 10;
    }

    IEnumerator DelayTime()
    {
        for (int i = 0; i < 12; i++) {
            GameObject temp = Instantiate(Bullet);
            float x = Mathf.Cos(_degree2 * Mathf.Deg2Rad); //x값  
            float y = Mathf.Sin(_degree2 * Mathf.Deg2Rad); //y값
            temp.GetComponent<BulletMove>().Init(new Vector3(x, y, 0).normalized, _speed);
            _degree2 += 10;
            Destroy(temp, 2f);
            yield return new WaitForSeconds(0.1f);
        }

        yield return null;
    }
}
