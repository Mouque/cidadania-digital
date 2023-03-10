using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NextSideBar : MonoBehaviour
{
    public delegate void Transition();

    [SerializeField] private static GameObject Tela3;
    [SerializeField] private static GameObject SearchBar;

    [SerializeField] private Button transparentButton;
    [SerializeField] NextSideBar.TransitionName transition;
    public enum TransitionName { ToScreen3 };

    Transition[] transitions = { ToScreen3 };

    Transition ExecuteTransition(TransitionName name)
    {
        return transitions[(int)name];
    }

    public static void ToScreen3()
    {
        Debug.Log("ToScreen3 executada");
        SearchBar = GameObject.Find("SearchBar");
        Tela3 = GameObject.Find("Tela 3");
        GameObjectsHandler.Instance.ChangeGameObjectParent(SearchBar, Tela3);
        AnimationHandler_2.Instance.Screen_2_Exit();
        AnimationHandler_3.Instance.Screen_3_Enter();
    }

    public void OnButtonClick()
    {
        transparentButton.interactable = false;
        ExecuteTransition(transition).Invoke();
        StartCoroutine(AnimationHandler_2.Instance.HideNextSideBar());
    }

    void OnDisable()
    {
        transparentButton.interactable = true;

    }



}
