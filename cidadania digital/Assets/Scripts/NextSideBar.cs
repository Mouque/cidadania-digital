using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class NextSideBar : MonoBehaviour, IPointerDownHandler
{
    public delegate void Transition();
    [SerializeField] NextSideBar.TransitionName transition;
    public enum TransitionName { ToScreen3, ToScreen4 };

    Transition[] transitions = { ToScreen3, ToScreen4 };

    Transition ExecuteTransition(TransitionName name)
    {
        return transitions[(int)name];
    }

    public static void ToScreen3()
    {
        Debug.Log("ToScreen3 executada");
    }
    public static void ToScreen4()
    {
        Debug.Log("ToScreen4 executada");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Foi");
        ExecuteTransition(transition).Invoke();
    }

}
