using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SearchBar : MonoBehaviour
{
    [SerializeField] private Button searchBarTransparentButton;



    public void OnButtonClick()
    {
        AnimationHandler_3.Instance.Screen_3_Exit();
        searchBarTransparentButton.interactable = false;
        AnimationHandler_4.Instance.Screen_4_Enter();
    }

    void Start()
    {
        searchBarTransparentButton.interactable = true;
    }

}
