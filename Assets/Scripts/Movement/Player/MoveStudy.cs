using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveStudy : MonoBehaviour
{
    [SerializeField] private Rigidbody2D moveAble;
    [SerializeField] private Transform _square;
    private float _time = 0;
    private float _moveX = 0, _moveY = 0;
    public float _speed = 5;
    void Awake()
    {
        moveAble = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        //MovementControll_RigidBody();
        //MovmentControll_Transform();
        checkAxis();
        

    }

    void MovementControll_RigidBody() //Using Vector2
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            moveAble.transform.position = new Vector2(moveAble.transform.position.x + 1, moveAble.transform.position.y);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            moveAble.transform.position = new Vector2(moveAble.transform.position.x - 1, moveAble.transform.position.y); 
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            moveAble.transform.position = new Vector2(moveAble.transform.position.x, moveAble.transform.position.y + 1);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            moveAble.transform.position = new Vector2(moveAble.transform.position.x, moveAble.transform.position.y - 1);
        }
        if (Input.GetMouseButtonDown(1))
        {
            moveAble.transform.position = new Vector2(moveAble.transform.position.x + 1, moveAble.transform.position.y);
        }
        if (Input.GetMouseButtonDown(0))
        {
            moveAble.transform.position = new Vector2(moveAble.transform.position.x - 1, moveAble.transform.position.y);
        }
       
    }
    void checkAxis()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        _time = Time.deltaTime;
        //if (horizontal != 0 || vertical != 0)
        //{
        //    Debug.Log($"Horizontal Axis: {horizontal}, Vectical Axis: {vertical}");

        //}
        _square.position += new Vector3(horizontal *_time *_speed, vertical*_time*_speed, 0);
        //_moveX = _moveX + horizontal;  // x axis movment
        //_moveY = _moveY + vertical;    // y axis movement
        
        //if (horizontal != 0) Debug.Log(_time);
        
        
        

    }

    void MovmentControll_Transform() // using Vector3
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            _square.position += Vector3.right;
            
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            _square.position += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            _square.position += Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _square.position += Vector3.down;
        }
        if (Input.GetMouseButtonDown(1))
        {
            _square.position += new Vector3(1, 0, 0);
        }
        if (Input.GetMouseButtonDown(0))
        {
            _square.position += new Vector3(-1, 0, 0);
        }
    }

    


}
