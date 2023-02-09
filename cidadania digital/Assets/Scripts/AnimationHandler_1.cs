using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class AnimationHandler_1 : MonoBehaviour
{
    public static AnimationHandler_1 Instance;

    void OnEnable()
    {
        Debug.Log("Animation Handler 1 ativo");
        Screen_1_Enter();
        Instance = this;
    }

    [SerializeField] private Image searchBarImage, searchButtonImage;
    [SerializeField] private TMP_Text heading, text;

    public void Screen_1_Enter()
    {
        heading.transform.DOLocalMoveY(20f, 2f).From().SetEase(Ease.InOutQuint);
        heading.DOFade(0f, 2f).From().SetEase(Ease.InOutQuint);

        searchBarImage.transform.DOLocalMoveY(20f, 2f).From().SetEase(Ease.InOutQuint);
        searchBarImage.DOFade(0f, 2f).From().SetEase(Ease.InOutQuint);

        text.transform.DOLocalMoveY(20f, 2f).From().SetEase(Ease.InOutQuint);
        text.DOFade(0f, 2f).From().SetEase(Ease.InOutQuint);

        searchButtonImage.transform.DOLocalMoveY(20f, 2f).From().SetEase(Ease.InOutQuint);
        searchButtonImage.DOFade(0f, 2f).From().SetEase(Ease.InOutQuint);
    }

    public void Screen_1_Exit()
    {
        heading.transform.DOLocalMoveY(20f, 1f).SetEase(Ease.InOutQuint);
        heading.DOFade(0f, 1f).SetEase(Ease.InOutQuint);

        searchBarImage.transform.DOLocalMoveY(50f, 1f).SetEase(Ease.InOutQuint);

        text.transform.DOLocalMoveY(50f, 1f).SetEase(Ease.InOutQuint);

        searchButtonImage.transform.DOLocalMoveY(50f, 1f).SetEase(Ease.InOutQuint);
    }

    void Start()
    {

    }
}
