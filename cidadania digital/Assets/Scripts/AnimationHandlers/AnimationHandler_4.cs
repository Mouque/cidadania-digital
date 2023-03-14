using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler_4 : MonoBehaviour
{
    public static AnimationHandler_4 Instance;

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

    }

    public void Screen_4_Exit()
    {
        Debug.Log("Screen 3 Exit");

    }

    IEnumerator EnterAnimation()
    {

        yield return null;
    }

    IEnumerator ExitAnimation()
    {

        yield return null;
    }


}
