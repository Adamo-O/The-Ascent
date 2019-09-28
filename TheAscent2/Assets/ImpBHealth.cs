using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpBHealth : MonoBehaviour
{
    public static int impBHealth = 100;
    public static bool killed = false;
    private bool invincible = false;
    int damage = AttacTrigger.dmg;

    [SerializeField]
    float refreshRateImpB = 1f;


    public void Damage(int damage)
    {
        if (!invincible)
        {
            impBHealth -= damage;

            print("Enemy Imp was damaged. You're doing great.");
            StartCoroutine(Wait());
        }

    }
    IEnumerator Wait()
    {
        invincible = true;
        damage = 0;
        Debug.Log("Before waiting " + refreshRateImpB + " seconds");
        yield return new WaitForSeconds(refreshRateImpB);
        Debug.Log("After waiting " + refreshRateImpB + " seconds");
        damage = 20;
        invincible = false;
    }
    void Update()
    {
        if (impBHealth <= 0)
        {
            Destroy(gameObject);
            killed = true;
            print("Enemy Imp has been eliminated. Nice one.");
        }
    }

}
