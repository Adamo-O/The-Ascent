using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpHealth : MonoBehaviour
{
    public static int impAHealth = 100;
    public static bool killed = false;
    private bool invincible = false;
    int damage = AttacTrigger.dmg;

    [SerializeField]
    float refreshRateImp = 1f;
    

    public void Damage(int damage)
    {
        if(!invincible)
        {
            impAHealth -= damage;

            print("Enemy Imp was damaged. You're doing great.");
            StartCoroutine(Wait());
        }
        
    }
    IEnumerator Wait()
    {
        invincible = true;
        damage = 0;
        Debug.Log("Before waiting " + refreshRateImp + " seconds");
        yield return new WaitForSeconds(refreshRateImp);
        Debug.Log("After waiting " + refreshRateImp + " seconds");
        damage = 20;
        invincible = false;
    }
    void Update()
    {
        if (impAHealth <= 0)
        {
            Destroy(gameObject);
            killed = true;
            print("Enemy has been eliminated");
        }
    }

}
