using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttonsystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Button01(){
        SceneManager.LoadSceneAsync(1);
    }

    public void Button02(){
        SceneManager.LoadSceneAsync(2);
    }

    public void Button03(){
        SceneManager.LoadSceneAsync(3);
    }

    public void Button04(){
        Application.Quit();
    }

    public void Button05(){
        SceneManager.LoadSceneAsync(5);
    }
}
