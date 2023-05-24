using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSlimeMove : MonoBehaviour
{
    [SerializeField] GameObject _slime;
    [SerializeField] Transform[] _points;
    [SerializeField] Transform _hero;


    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject slime = Instantiate(_slime);
            slime.GetComponent<NpcMovement>().Initialize(_points, _hero);
        }
    }
}
