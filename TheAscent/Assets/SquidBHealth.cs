using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquidBHealth : MonoBehaviour
{
    public static int squidBHealth = 100;
    public static bool squidBKilled = false;
    private bool invincible = false;
    int damage = AttacTrigger.dmg;

    [SerializeField]
    float refreshRateSquidB = 1f;

    public void Damage(int damage)
    {
        if (!invincible)
        {
            squidBHealth -= damage;
            print("Enemy squid was damaged. Continue your chaos.");
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        invincible = true;
        damage = 0;
        Debug.Log("Before waiting " + refreshRateSquidB + " seconds");
        yield return new WaitForSeconds(refreshRateSquidB);
        Debug.Log("After waiting " + refreshRateSquidB + " seconds");
        damage = 20;
        invincible = false;
    }
    void Update()
    {
        if (squidBHealth <= 0)
        {
            Destroy(gameObject);
            squidBKilled = true;
            print("Enemy Squid has been eliminated. You're doing extraordinarily.");
        }

    }

}
