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

    [SerializeField] private GameObjectsHandler gameObjectsHandler;

    void Start()
    {
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        AnimationHandler_1.Instance.Screen_1_Exit();
        gameObjectsHandler.ChangeGameObjectParent(SearchBar, Tela2);
        AnimationHandler_1.Instance.gameObject.SetActive(false);
        this.enabled = false;
    }
}
