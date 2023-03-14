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
    [SerializeField] private Image searchBarImage, searchButtonImage;
    [SerializeField] private TMP_Text searchBarText;

    void Awake()
    {
        Instance = this;
    }
    void OnEnable()
    {
        Debug.Log("Animation Handler 2 rodando");

    }

    void OnDisable()
    {
        Debug.Log("Animation Handler 2 desativado");
    }

    // Update is called once per frame
    public void Screen_2_Enter()
    {
        Debug.Log("AnimHandler2 Screen 2 Enter");
        StartCoroutine(EnterAnimation());

    }

    public void Screen_2_Exit()
    {
        Debug.Log("AnimHandler2 Screen 2 Exit");
        StartCoroutine(ExitAnimation());
        StartCoroutine(DisableGameObjects());


    }

    IEnumerator EnterAnimation()
    {
        heading.gameObject.SetActive(true);
        nassauResult.gameObject.SetActive(true);

        heading.DOFade(0f, 1f).From().SetEase(Ease.InOutQuint);

        nassauResult.DOFade(0f, 2f).From().SetEase(Ease.InOutQuint);

        yield return new WaitForSeconds(5f);

        Debug.Log("Ativando NextSideBar");
        StartCoroutine(ShowNextSideBar());
    }

    IEnumerator ExitAnimation()
    {

        searchBarImage.transform.DOLocalMoveY(searchBarImage.transform.localPosition.y - 25f, 1f).SetEase(Ease.InOutQuint);

        searchBarText.transform.DOLocalMoveY(searchBarText.transform.localPosition.y - 25f, 1f).SetEase(Ease.InOutQuint);

        searchButtonImage.transform.DOLocalMoveY(searchButtonImage.transform.localPosition.y - 25f, 1f).SetEase(Ease.InOutQuint);

        heading.transform.DOLocalMoveY(heading.transform.localPosition.y + 40f, 2f).SetEase(Ease.InOutQuint);
        heading.DOFade(0f, 1f).SetEase(Ease.InOutQuint);

        nassauResult.transform.DOLocalMoveY(nassauResult.transform.localPosition.y - 40f, 2f).SetEase(Ease.InOutQuint);
        nassauResult.DOFade(0f, 1f).SetEase(Ease.InOutQuint);
        yield return null;
    }

    IEnumerator DisableGameObjects()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("Screen 2: heading e Nassau image desativados");
        heading.gameObject.SetActive(false);
        nassauResult.gameObject.SetActive(false);
        this.enabled = false;

    }

    IEnumerator ShowNextSideBar()
    {
        NextSideBar.gameObject.SetActive(true);
        NextSideBar.transform.DOLocalMoveX(NextSideBar.transform.localPosition.x + 230f, 2f).From().SetEase(Ease.InOutQuint);
        NextSideBarArrow.transform.DOLocalMoveX(NextSideBarArrow.transform.localPosition.x + 230f, 2f).From().SetEase(Ease.InOutQuint);
        yield return null;
    }

    public IEnumerator HideNextSideBar()
    {
        NextSideBar.transform.DOLocalMoveX(NextSideBar.transform.localPosition.x + 230f, 1f).SetEase(Ease.InOutQuint);
        NextSideBarArrow.transform.DOLocalMoveX(NextSideBarArrow.transform.localPosition.x + 230f, 1f).SetEase(Ease.InOutQuint);
        yield return new WaitForSeconds(3f);
        NextSideBar.gameObject.SetActive(false);
    }
}
