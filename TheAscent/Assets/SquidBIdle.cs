using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquidBIdle : MonoBehaviour {
    public float idleposX = 6.17f;
    public float idleposY = 48.013f;
	// Use this for initialization
	void Start () {
        transform.localPosition = new Vector2(idleposX, idleposY);
    }
}
