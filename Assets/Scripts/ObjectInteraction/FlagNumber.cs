using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagNumber : MonoBehaviour
{
    [SerializeField] int flagNumber;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("�� ����� ��ȣ�� " + flagNumber + "�Դϴ�.");
    }
}
