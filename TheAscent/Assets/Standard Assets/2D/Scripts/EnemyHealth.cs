using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    public static int enemyHealth = 100;
    public static int killCounter = 0;
    //public int damage = 50;

    public void Damage(int damage)
    {
        enemyHealth -= damage;
        /*gameObject.GetComponent<Animation>().Play("Player_RedFlash");*/
        print("Ouch!");
    }
    void Update()
    {
        if(enemyHealth <= 0)
        {
            Destroy(gameObject);
            killCounter++;
            print("Enemy has been eliminated");
        }
    }
	
}
