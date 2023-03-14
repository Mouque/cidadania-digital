using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class AnimationHandler_1 : MonoBehaviour
{
    public static AnimationHandler_1 Instance;

    [SerializeField] private Image searchBarImage, searchButtonImage;
    [SerializeField] private TMP_Text heading, text;

    void Awake()
    {
        Instance = this;
    }
    void OnEnable()
    {
        Debug.Log("Animation Handler 1 rodando");
        Screen_1_Enter();

    }

    void OnDisable()
    {
        Debug.Log("Animation Handler 1 desativado");
    }

    public void Screen_1_Enter()
    {
        Debug.Log("AnimHandler1 Screen 1 Enter");
        StartCoroutine(EnterAnimation());
    }

    public void Screen_1_Exit()
    {
        Debug.Log("AnimHandler1 Screen 1 Exit");
        StartCoroutine(ExitAnimation());
        StartCoroutine(DisableGameObjects());
    }

    IEnumerator EnterAnimation()
    {
        heading.transform.DOLocalMoveY(heading.transform.localPosition.y + 40f, 2f).From().SetEase(Ease.InOutQuint);
        heading.DOFade(0f, 2f).From().SetEase(Ease.InOutQuint);

        searchBarImage.transform.DOLocalMoveY(searchBarImage.transform.localPosition.y + 20f, 2f).From().SetEase(Ease.InOutQuint);
        searchBarImage.DOFade(0f, 2f).From().SetEase(Ease.InOutQuint);

        text.transform.DOLocalMoveY(text.transform.localPosition.y + 20f, 2f).From().SetEase(Ease.InOutQuint);
        text.DOFade(0f, 2f).From().SetEase(Ease.InOutQuint);

        searchButtonImage.transform.DOLocalMoveY(searchButtonImage.transform.localPosition.y + 20f, 2f).From().SetEase(Ease.InOutQuint);
        searchButtonImage.DOFade(0f, 2f).From().SetEase(Ease.InOutQuint);

        yield return null;
    }

    IEnumerator ExitAnimation()
    {
        heading.transform.DOLocalMoveY(heading.transform.localPosition.y + 40f, 2f).SetEase(Ease.InOutQuint);
        heading.DOFade(0f, 1f).SetEase(Ease.InOutQuint);

        searchBarImage.transform.DOLocalMoveY(searchBarImage.transform.localPosition.y + 45f, 1f).SetEase(Ease.InOutQuint);

        text.transform.DOLocalMoveY(text.transform.localPosition.y + 45f, 1f).SetEase(Ease.InOutQuint);

        searchButtonImage.transform.DOLocalMoveY(searchButtonImage.transform.localPosition.y + 45f, 1f).SetEase(Ease.InOutQuint);


        AnimationHandler_2.Instance.Screen_2_Enter();

        yield return null;

    }
    IEnumerator DisableGameObjects()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("Screen 1: heading desativado");
        heading.gameObject.SetActive(false);
        this.enabled = false;

    }



}
