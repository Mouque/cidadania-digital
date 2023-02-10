using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.EventSystems;

public class SearchButton : MonoBehaviour, IPointerDownHandler
{
    // Start is called before the first frame update

    void Start()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Foi");
        AnimationHandler_1.Instance.Screen_1_Exit();
        this.enabled = false;
    }
}
