using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectDestroyer : MonoBehaviour
{
    [SerializeField] GameObject gameObjectToDestroy = null;

    public void DestroyGameObject()
    {
        Destroy(gameObjectToDestroy);
    }
}
