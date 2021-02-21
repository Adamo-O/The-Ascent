using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _GM : MonoBehaviour {
    public static int maxHealth = 100;
    public static _GM instance = null;
    void Awake()
    {
        if (instance == null)
            instance = this;

        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
    // Use this for initialization
        
    
    


    // Update is called once per frame
    void Update() {
        
    }

}