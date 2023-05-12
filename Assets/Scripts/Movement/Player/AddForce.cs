using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigid;


    private void FixedUpdate() //Function called once before physics calculation
    {
        float x = Input.GetAxisRaw("Horizontal");
        _rigid.AddForce(Vector2.right * x, ForceMode2D.Impulse);
        float jump = Input.GetAxisRaw("Jump");
        _rigid.AddForce(Vector2.up * jump, ForceMode2D.Impulse);

    }









}
