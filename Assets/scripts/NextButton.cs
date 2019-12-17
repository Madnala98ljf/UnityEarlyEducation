using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    public GameObject[] game;
    private NextNum gameController;
    public AudioSource[] audio;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
        gameController = gameControllerObject.GetComponent<NextNum> ();
    }

    public void Next(){
        gameController.num=gameController.num+1;
        if(gameController.num>8){
            gameController.num=0;
            game[8].SetActive(false);
            game[0].SetActive(true);
            //audio[8].Stop();
            //audio[0].Play();
        }else{
            game[gameController.num-1].SetActive(false);
            game[gameController.num].SetActive(true); 
            //audio[gameController.num-1].Stop();
            //audio[gameController.num].Play();
        }  
    }

    public void Previous(){
        gameController.num=gameController.num-1;
        if(gameController.num<0){
            game[0].SetActive(false);
            game[8].SetActive(true);
            //audio[0].Stop();
            //audio[8].Play();
            gameController.num=8;
        }else{
            game[gameController.num+1].SetActive(false);
            game[gameController.num].SetActive(true); 
            //audio[gameController.num+1].Stop();
            //audio[gameController.num].Play();
        }
    }
}
