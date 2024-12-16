using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TextSet : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField input;
    public TMP_InputField output;
    void Start()
    {
        input.onValueChanged.AddListener(OnInputField1ValueChanged);
        output.onEndEdit.AddListener(OnInputField2ValueChanged);
    }
    public void OnInputField1ValueChanged(string value)
    {
        input.text = value;
    }

    public void OnInputField2ValueChanged(string value)
    {
        output.text = value;
    }
    public void SetOutput()
    {
        output.text = input.text;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    
}
