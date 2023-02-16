using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class BackgroundAnimationHandler : MonoBehaviour
{
    public static BackgroundAnimationHandler Instance;

    [SerializeField]
    Transform redCircle, greenCircle, yellowPlus1, yellowPlus2, yellowPlus3, yellowTriangle;

    void Start()
    {
        Instance = this;
        Screen_1_Enter_Transition();
    }

    void Screen_1_Enter_Transition()
    {
        StartCoroutine(Screen_1_Enter_Animation());

    }

    public void To_Screen_2_Transition()
    {
        StartCoroutine(To_Screen_2_Animation());
    }

    IEnumerator To_Screen_2_Animation()
    {
        redCircle.DOScale(new Vector3(5f, 5f, 0f), 2f);
        redCircle.DOMove(new Vector3(redCircle.transform.position.x - 1000f, redCircle.transform.position.y + 1000f, 0f), 2f);

        yellowTriangle.DOScale(new Vector3(5f, 5f, 5f), 2f);
        greenCircle.DOScale(new Vector3(5f, 5f, 5f), 2f);

        yield return null;
    }

    IEnumerator Screen_1_Enter_Animation()
    {
        redCircle.DOScale(new Vector3(0f, 0f, 0f), 2f).From();
        greenCircle.DOScale(new Vector3(0f, 0f, 0f), 2f).From();
        yellowTriangle.DOScale(new Vector3(0f, 0f, 0f), 2f).From();

        yield return null;
    }
}
