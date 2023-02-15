using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameObjectsHandler : MonoBehaviour
{
    // Muda o parent do object
    public void ChangeGameObjectParent(GameObject gameObject, GameObject newParent)
    {
        gameObject.transform.SetParent(newParent.transform, true);
    }
}
