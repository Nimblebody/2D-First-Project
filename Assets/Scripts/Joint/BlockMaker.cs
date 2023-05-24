using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMaker : MonoBehaviour
{
    [SerializeField] GameObject _block;
    float _timer = 0;
    GameObject _makedBlock;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            _makedBlock = Instantiate(_block);
            Destroy(_makedBlock, 3f);
        }
    }

    void DestroyBlock()
    {
        if (_makedBlock != null)
        {
            Destroy(_makedBlock);
        }
    }
}
