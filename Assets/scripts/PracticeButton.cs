using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PracticeButton : MonoBehaviour
{
    private PracticeGame gameController;
    public GameObject win;
    public GameObject lose;
    public AudioSource audio;
    public AudioSource audio1;
    public AudioSource audio2;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
        gameController = gameControllerObject.GetComponent<PracticeGame> ();
        transform.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnClick()
    {
        audio2.Stop(); 
        Text text = this.transform.Find("Text").GetComponent<Text>();
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
