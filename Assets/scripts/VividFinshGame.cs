using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class VividFinshGame : MonoBehaviour
{
    private VividGame gameController;
    public GameObject win;
    public GameObject lose;
    public Text text;
    public AudioSource audio;
    public AudioSource audio1;
    public AudioSource audio2;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
        gameController = gameControllerObject.GetComponent<VividGame> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Submission() {
        audio2.Stop(); 
        if(gameController.sum==Convert.ToInt32(text.text)){
            win.SetActive(true);
            audio.Play(); 
        }else
        {
            lose.SetActive(true);
            audio1.Play(); 
        }
    }
}
