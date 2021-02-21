using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarNew : MonoBehaviour {
    public float totalHp = 100;
    public float currentHp = 100;

	// Use this for initialization
	void Start () {
        currentHp = totalHp;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) 
        {
            TakeDamage();
        }
	}

    void TakeDamage()
    {
        currentHp -= 10;
        transform.localScale = new Vector3((currentHp / totalHp), 1, 1);
    }
}
