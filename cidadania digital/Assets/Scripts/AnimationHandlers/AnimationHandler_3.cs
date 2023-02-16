using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class AnimationHandler_3 : MonoBehaviour
{
    public static AnimationHandler_3 Instance;

    [SerializeField] private TMP_Text heading1;
    [SerializeField] private TMP_Text heading2;

    void Awake()
    {
        Instance = this;

    }

    void OnEnable()
    {
        Debug.Log("Animation Handler 3 rodando");
    }

    public void Screen_3_Enter()
    {
        Debug.Log("Screen 3 Enter");

        StartCoroutine(EnterAnimation());

        // ativar script da searchbar

    }

    IEnumerator EnterAnimation()
    {
        heading1.gameObject.SetActive(true);
        heading2.gameObject.SetActive(true);

        heading1.transform.DOLocalMoveY(heading1.transform.localPosition.y + 40f, 2f).From().SetEase(Ease.InOutQuint);
        heading1.DOFade(0f, 2f).From().SetEase(Ease.InOutQuint);

        heading2.transform.DOLocalMoveY(heading2.transform.localPosition.y - 40f, 2f).From().SetEase(Ease.InOutQuint);
        heading2.DOFade(0f, 2f).From().SetEase(Ease.InOutQuint);

        yield return null;
    }
}
