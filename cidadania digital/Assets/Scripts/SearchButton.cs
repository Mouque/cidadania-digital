using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;

public class SearchButton : MonoBehaviour
{
    [SerializeField] private GameObject Tela2;
    [SerializeField] private GameObject SearchBar;
    [SerializeField] private Button transparentButton;


    public void OnButtonClick()
    {
        AnimationHandler_1.Instance.Screen_1_Exit();
        //BackgroundAnimationHandler.Instance.To_Screen_2_Transition();
        GameObjectsHandler.Instance.ChangeGameObjectParent(SearchBar, Tela2);
        transparentButton.interactable = false;
        transparentButton.gameObject.GetComponent<Image>().raycastTarget = false;
    }


}
