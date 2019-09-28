using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomTest : MonoBehaviour {
    // Use this for initialization
    //static SceneManager Instance;
    void Awake()
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log(scene.name);
        Debug.Log(scene.buildIndex);
    }
	void Start () {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log(scene.name);
        Debug.Log(scene.buildIndex);
        /*if(Instance != null)
        {
            GameObject.Destroy(gameObject);
        }
        else []*/
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
