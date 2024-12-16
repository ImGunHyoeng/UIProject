using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCommentWindow : MonoBehaviour
{
    public GameObject comment;
    public MouseDownCheck m_MouseDownCheck;

    //MouseDownCheck MouseDownCheck;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ChangeTrue()
    {
        m_MouseDownCheck.enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
