using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField] WheelJoint2D _frontWheel;
    [SerializeField] WheelJoint2D _rearWheel;
    [SerializeField] float _forwardSpeed;
    [SerializeField] float _backSpeed;
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            JointMotor2D motor = new JointMotor2D();
            motor.motorSpeed = _forwardSpeed;
            motor.maxMotorTorque = 5000;
            _frontWheel.useMotor = true;
            _frontWheel.motor = motor;
            
        }
        if(Input.GetKeyUp(KeyCode.D)) {
            _frontWheel.useMotor = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            JointMotor2D motor = new JointMotor2D();
            motor.motorSpeed = _backSpeed;
            motor.maxMotorTorque = 5000;
            _rearWheel.useMotor = true;
            _rearWheel.motor = motor;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            _rearWheel.useMotor= false;
        }

        //4·û±¸µ¿
        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.D))
        {
            JointMotor2D motor = new JointMotor2D();
            motor.motorSpeed = _forwardSpeed;
            motor.maxMotorTorque = 5000;
            _frontWheel.useMotor = true;
            _frontWheel.motor = motor;
            _rearWheel.useMotor = true;
            _rearWheel.motor = motor;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.D))
        {
            _frontWheel.useMotor = false;
            _rearWheel.useMotor = false;
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.A))
        {
            JointMotor2D motor = new JointMotor2D();
            motor.motorSpeed = _backSpeed;
            motor.maxMotorTorque = 5000;
            _frontWheel.useMotor = true;
            _frontWheel.motor = motor;
            _rearWheel.useMotor = true;
            _rearWheel.motor = motor;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.A))
        {
            _frontWheel.useMotor = false;
            _rearWheel.useMotor = false;
        }
    }
}
