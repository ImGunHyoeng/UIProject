using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountUp : MonoBehaviour
{
    bool IsClicked=false;
    public TextMeshProUGUI m_TextMeshProUGUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlusEvent()
    {
        int temp = int.Parse(m_TextMeshProUGUI.text);
        if(IsClicked)
        {
            temp -= 1;
            m_TextMeshProUGUI.text = temp.ToString();
            IsClicked = false;
        }
        else 
        {
            temp += 1;
            m_TextMeshProUGUI.text = temp.ToString();
            IsClicked = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
