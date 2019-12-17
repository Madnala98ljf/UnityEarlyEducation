using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarChange : MonoBehaviour
{
    public Sprite Mysprit;
    private Sprite Defallsprit;
    private bool ischange = false;
    private GameSystem gameController;
    


    // Use this for initialization
    void Start () {
        GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
        gameController = gameControllerObject.GetComponent<GameSystem> ();
        ///监听点击事件
        transform.GetComponent<Button>().onClick.AddListener(OnClick);
        ///获取按钮初始默认图片
        Defallsprit = transform.GetComponent<Image>().sprite;
    }
    
    // Update is called once per frame
    void Update () {
        
    }

    void OnClick()
    {
        ischange = !ischange;
        if (ischange)
        {
            ///更改按钮图片
            transform.GetComponent<Image>().sprite = Mysprit;
            gameController.add_count();
        }
        else
        {
            ///还原按钮图片
            transform.GetComponent<Image>().sprite = Defallsprit;
            gameController.reduce_count();
        }
    }

    
}
