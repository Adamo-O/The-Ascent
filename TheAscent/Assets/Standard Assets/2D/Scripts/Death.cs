using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Death : MonoBehaviour {
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "CharacterRobotBoy")
        {
            Destroy(collision.gameObject);
        }
    }
	// Update is called once per frame
}
