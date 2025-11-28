using System;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    [SerializeField]
    GameManager gameManager;

    public void Destroy()
    {
        gameManager.UpdateScore();
        Destroy(gameObject);
    }
}
