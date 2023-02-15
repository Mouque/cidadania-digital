using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class AnimationHandler_2 : MonoBehaviour
{
    public static AnimationHandler_2 Instance;

    [SerializeField] private TMP_Text heading;
    [SerializeField] private Image nassauResult;
    [SerializeField] private Image NextSideBar;
    [SerializeField] private Image NextSideBarArrow;

    void Awake()
    {
        Instance = this;
    }
    void OnEnable()
    {
        Debug.Log("Animation Handler 2 rodando");

    }

    // Update is called once per frame
    public void Screen_2_Enter()
    {
        Debug.Log("Screen 2 Enter");
        StartCoroutine(EnterAnimation());

    }

    IEnumerator EnterAnimation()
    {
        heading.gameObject.SetActive(true);
        nassauResult.gameObject.SetActive(true);

        heading.DOFade(0f, 1f).From().SetEase(Ease.InOutQuint);

        nassauResult.DOFade(0f, 2f).From().SetEase(Ease.InOutQuint);

        yield return new WaitForSeconds(5f);

        Debug.Log("Ativando NextSideBar");

        NextSideBar.gameObject.SetActive(true);
        NextSideBar.transform.DOLocalMoveX(NextSideBar.transform.localPosition.x + 230f, 2f).From().SetEase(Ease.InOutQuint);
        NextSideBarArrow.transform.DOLocalMoveX(NextSideBarArrow.transform.localPosition.x + 230f, 2f).From().SetEase(Ease.InOutQuint);

    }
}
