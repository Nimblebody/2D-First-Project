using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"Input get collider name : {collision.name}");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"Input get collider name : {collision.collider.name}");
    }
}
