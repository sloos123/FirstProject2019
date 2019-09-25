using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Image theButton;

    public void OnPointerEnter(PointerEventData eventData)
    {
        theButton.color = Color.red; 
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        theButton.color = Color.green; 
    }
}

