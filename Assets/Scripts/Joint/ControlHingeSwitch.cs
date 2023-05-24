using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ControlHingeSwitch : MonoBehaviour
{
    [SerializeField] HingeJoint2D _hinge;
    
    int _triggerCount = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            JointMotor2D _motor = new JointMotor2D();
            _motor.maxMotorTorque = 10000;
            _motor.motorSpeed = -150;
            _hinge.motor = _motor;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            JointMotor2D _motor = new JointMotor2D();
            _motor.maxMotorTorque = 50;
            _motor.motorSpeed = -150;
            _hinge.motor = _motor;
        }
    }

}
