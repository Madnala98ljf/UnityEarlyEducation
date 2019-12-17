using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    public static GameSystem _instance;
    public int num;
    public int count;
    public Sprite[] Mysprit;
    public Image image;

    private void Awake()
    {
        _instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        num=Random.Range (1, 10);
        image.sprite = Mysprit[num-1];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void add_count(){
        count=count+1;
    }

    public void reduce_count(){
        count=count-1;
    }



}
