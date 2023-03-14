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
    [SerializeField] private Transform searchBar;
    [SerializeField] private Image searchBarImage, searchButtonImage;
    [SerializeField] private TMP_Text searchBarText;

    void Awake()
    {
        Instance = this;

    }

    void OnEnable()
    {
        Debug.Log("Animation Handler 3 rodando");

    }

    void OnDisable()
    {
        Debug.Log("Animation Handler 3 desativado");
    }

    public void Screen_3_Enter()
    {
        Debug.Log("AnimHandler3 Screen 3 Enter");

        StartCoroutine(EnterAnimation());

        // ativar script da searchbar
        searchBar.GetComponent<SearchBar>().enabled = true;



    }

    public void Screen_3_Exit()
    {
        Debug.Log("AnimHandler3 Screen 3 Exit");
        StartCoroutine(ExitAnimation());
        StartCoroutine(DisableGameObjects());

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

    IEnumerator ExitAnimation()
    {
        searchBarImage.transform.DOLocalMoveX(searchBarImage.transform.localPosition.x + 250f, 1f).SetEase(Ease.InOutQuint);
        searchButtonImage.transform.DOLocalMoveX(searchButtonImage.transform.localPosition.x + 250f, 1f).SetEase(Ease.InOutQuint);
        searchBarText.transform.DOLocalMoveX(searchBarText.transform.localPosition.x + 250f, 1f).SetEase(Ease.InOutQuint);

        heading1.transform.DOLocalMoveY(heading1.transform.localPosition.y + 40f, 1f).SetEase(Ease.InOutQuint);
        heading1.DOFade(0f, 1f).SetEase(Ease.InOutQuint);

        heading2.transform.DOLocalMoveY(heading2.transform.localPosition.y - 40f, 1f).SetEase(Ease.InOutQuint);
        heading2.DOFade(0f, 1f).SetEase(Ease.InOutQuint);

        yield return new WaitForSeconds(1f);
    }

    IEnumerator DisableGameObjects()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("Screen 3: heading 1 e 2 desativados");
        heading1.gameObject.SetActive(false);
        heading2.gameObject.SetActive(false);
        this.enabled = false;

    }
}
