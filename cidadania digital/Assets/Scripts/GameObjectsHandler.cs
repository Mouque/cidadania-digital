using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameObjectsHandler : MonoBehaviour
{
    public static GameObjectsHandler Instance;

    void Start()
    {
        Instance = this;
    }
    // Muda o parent do object
    public void ChangeGameObjectParent(GameObject gameObject, GameObject newParent)
    {
        gameObject.transform.SetParent(newParent.transform, true);
    }
}
