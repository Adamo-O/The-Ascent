using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour {
	void Update () {
		if (Input.GetButtonDown("Quit"))
        {
            Application.Quit();
        }
	}
}
