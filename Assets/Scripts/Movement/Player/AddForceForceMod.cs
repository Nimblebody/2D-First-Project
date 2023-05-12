using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceForceMod : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        rb.AddForce(Vector2.right * x * 10, ForceMode2D.Force);
    }
}
