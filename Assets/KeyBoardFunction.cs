using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardFunction : MonoBehaviour
{

    bool IsDistrupt=false;
    public GameObject KeyBoard;
    public bool KeyBoardOnOffProperty
    {
        get { return IsDistrupt; }
        set { IsDistrupt = value; }
    }//프로퍼티 설정

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetDistrupt(bool condition)
    {
        IsDistrupt = condition;
    }
    public void DelayOff()
    {
        StartCoroutine(DelayOffCoroutine());
    }
    IEnumerator DelayOffCoroutine()
    {
        yield return new WaitForSeconds(1.0f);
        if(!IsDistrupt)
            KeyBoard.SetActive(false);
    }
}
