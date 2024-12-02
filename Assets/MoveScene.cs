using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MoveScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void NextScene(string sceneName)
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(sceneName);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
