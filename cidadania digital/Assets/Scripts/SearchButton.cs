using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.EventSystems;
using System;

public class SearchButton : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private GameObject Tela2;
    [SerializeField] private GameObject SearchBar;

    void Start()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        AnimationHandler_1.Instance.Screen_1_Exit();
        BackgroundAnimationHandler.Instance.To_Screen_2_Transition();
        GameObjectsHandler.Instance.ChangeGameObjectParent(SearchBar, Tela2);
        this.enabled = false;
    }
}
