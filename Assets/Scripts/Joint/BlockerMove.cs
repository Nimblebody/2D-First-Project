using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BlockerMove : MonoBehaviour
{
    TargetJoint2D _targetJoint2D;
    void Start()
    {
        _targetJoint2D = GetComponent<TargetJoint2D>();
    }

    private void FixedUpdate()
    {
        Debug.Log(Input.mousePosition);
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _targetJoint2D.target = worldPos;
        
    }

}
