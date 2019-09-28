using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquidHealth : MonoBehaviour
{
    public static int squidAHealth = 100;
    public static bool squidKilled = false;
    private bool invincible = false;
    int damage = AttacTrigger.dmg;

    [SerializeField]
    float refreshRateSquid = 1f;

    public void Damage(int damage)
    {
        if (!invincible)
        {
            squidAHealth -= damage;
            print("Enemy squid was damaged. Continue your chaos.");
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        invincible = true;
        damage = 0;
        Debug.Log("Before waiting " + refreshRateSquid + " seconds");
        yield return new WaitForSeconds(refreshRateSquid);
        Debug.Log("After waiting " + refreshRateSquid + " seconds");
        damage = 20;
        invincible = false;
    }
    void Update()
    {
        if (squidAHealth <= 0)
        {
            Destroy(gameObject);
            squidKilled = true;
            print("Enemy Squid has been eliminated. You're doing extraordinarily.");
        }
        
    }

}
