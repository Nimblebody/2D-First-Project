using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInteractive : MonoBehaviour
{
    [SerializeField] Text _text;
    [SerializeField] Image _image;
    int _index = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _image.fillAmount += Time.deltaTime;
            if(_image.fillAmount >= 1)
            {
                _image.fillAmount = 0;
            }
        }
    }

    public void OnBtnclickEvent()
    {
        _index++;
        string playerColor = "blue";
        Debug.Log($"Button has been clicked {_index} times");
        _text.text = "<color="+ playerColor +">"+_index.ToString()+"</color><size=17><b> Clicked</b></size>";
        //_text.color = Color.blue;
    }
}
