using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDownCheck : MonoBehaviour
{
    public GameObject obj;
    public CheckCommentWindow commentWindow;
    bool IsCheck = false;
    public void SetCheck(bool value)
    {
        IsCheck = value;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IsCheck)
        {
            MousePressGameObejctOff();
        }
    }
    
    public void MousePressGameObejctOff()
    {
        if (IsMouseButton())
            Off();
    }
    public void Off()
    {
        obj.SetActive(false);
        if(commentWindow)
            commentWindow.ChangeTrue();
    }
    public bool IsMouseButton()
    {
        return Input.GetMouseButtonDown(0);
    }
}
