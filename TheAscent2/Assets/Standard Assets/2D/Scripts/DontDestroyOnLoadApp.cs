using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoadApp : MonoBehaviour {
    public static int currentHealth = 100;
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);

    }
    public void GameOver()
    {
        enabled = false;
    }
}
