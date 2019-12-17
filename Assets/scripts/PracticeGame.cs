using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PracticeGame : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;
    public int sum;
    public Sprite[] Mysprit;
    public Sprite[] Symbol;
    public Image image_1;
    public Image image_2;
    public Image image_3;
    // Start is called before the first frame update
    void Start()
    {
        num1=Random.Range (1, 10);
        num2=Random.Range (1, 10);
        num3=Random.Range (0, Symbol.Length);
        image_3.sprite = Symbol[num3];
        if(num1>num2){
            image_1.sprite = Mysprit[num1-1];
            image_2.sprite = Mysprit[num2-1];
            if(num3==0)
                sum=num1+num2;
            else
                sum=num1-num2;
        }else
        {
            image_2.sprite = Mysprit[num1-1];
            image_1.sprite = Mysprit[num2-1];
            if(num3==0)
                sum=num1+num2;
            else
                sum=num2-num1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
