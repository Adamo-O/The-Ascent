using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killPlayer : MonoBehaviour {
    // Use this for initialization
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DeathBarrier")
        {
            Destroy(gameObject);
            Debug.Log("You died");
            //gameObject.transform.TransformPoint(new Vector3(0, 1, 0));
            this.transform.position = new Vector3(0, 1);
        }
    }
}
