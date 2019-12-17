using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmissionGame : MonoBehaviour
{
    private GameSystem gameController;
    public GameObject win;
    public GameObject lose;
    public AudioSource audio;
    public AudioSource audio1;
    public AudioSource audio2;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
        gameController = gameControllerObject.GetComponent<GameSystem> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Submission() {
        audio2.Stop(); 
        if(gameController.count==gameController.num){
            win.SetActive(true);
            audio.Play(); 
        }else
        {
            lose.SetActive(true);
            audio1.Play(); 
        }
    }

}
