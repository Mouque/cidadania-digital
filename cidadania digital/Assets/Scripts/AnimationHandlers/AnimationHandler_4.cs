using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class AnimationHandler_4 : MonoBehaviour
{
    public static AnimationHandler_4 Instance;

    [SerializeField] private TMP_Text heading1, heading2;
    [SerializeField] private Transform searchBar;

    void Awake()
    {
        Instance = this;

    }

    void OnEnable()
    {
        Debug.Log("Animation Handler 4 rodando");

    }

    void OnDisable()
    {
        Debug.Log("Animation Handler 4 desativado");
    }

    public void Screen_4_Enter()
    {
        Debug.Log("Screen 4 Enter");
        StartCoroutine(EnterAnimation());




    }

    public void Screen_4_Exit()
    {
        Debug.Log("Screen 3 Exit");

    }

    IEnumerator EnterAnimation()
    {
        heading1.gameObject.SetActive(true);
        heading2.gameObject.SetActive(true);
        searchBar.gameObject.SetActive(true);

        heading1.transform.DOLocalMoveY(heading1.transform.localPosition.y + 40f, 2.4f).From().SetEase(Ease.InOutQuint);
        heading1.DOFade(0f, 2.4f).From().SetEase(Ease.InOutQuint);

        heading2.transform.DOLocalMoveY(heading2.transform.localPosition.y - 40f, 2.4f).From().SetEase(Ease.InOutQuint);
        heading2.DOFade(0f, 2.4f).From().SetEase(Ease.InOutQuint);

        searchBar.DOLocalMoveX(searchBar.localPosition.x + 2500f, 2f).From().SetEase(Ease.InOutQuint);
        yield return null;
    }

    IEnumerator ExitAnimation()
    {

        yield return null;
    }


}
