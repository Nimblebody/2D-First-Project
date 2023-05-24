using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMove : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * 10;
        rb.velocity = new Vector3(x, rb.velocity.y, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * 10, ForceMode2D.Impulse);
        }
    }
}
