using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushyHealth : MonoBehaviour
{
    public static int mushyAHealth = 100;
    public static bool mushyKilled = false;
    private bool invincible = false;
    int damage = AttacTrigger.dmg;

    [SerializeField]
    float refreshRateMushy = 1f;

    public void Damage(int damage)
    {
        if (!invincible)
        {
            mushyAHealth -= damage;
            print("Enemy mushy the mushroom man was damaged. Embrace the bloodlust. Allow it to overcome you.");
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        invincible = true;
        damage = 0;
        Debug.Log("Before waiting " + refreshRateMushy + " seconds");
        yield return new WaitForSeconds(refreshRateMushy);
        Debug.Log("After waiting " + refreshRateMushy + " seconds");
        damage = 20;
        invincible = false;
    }
    void Update()
    {
        if (mushyAHealth <= 0)
        {
            Destroy(gameObject);
            mushyKilled = true;
            print("Enemy Mushy has been eliminated. Congratulations, killer.");
        }

    }

}
