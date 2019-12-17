using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AudioSourceMain : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public AudioSource audio;
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        audio.Play(); 
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        audio.Stop();
    }

}
