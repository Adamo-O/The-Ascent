using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushyBHealth : MonoBehaviour
{
    public static int mushyBHealth = 100;
    public static bool mushyBKilled = false;
    private bool invincible = false;
    int damage = AttacTrigger.dmg;

    [SerializeField]
    float refreshRateMushyB = 1f;

    public void Damage(int damage)
    {
        if (!invincible)
        {
            mushyBHealth -= damage;
            print("Enemy mushy the mushroom man was damaged. Embrace the bloodlust. Allow it to overcome you.");
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        invincible = true;
        damage = 0;
        Debug.Log("Before waiting " + refreshRateMushyB + " seconds");
        yield return new WaitForSeconds(refreshRateMushyB);
        Debug.Log("After waiting " + refreshRateMushyB + " seconds");
        damage = 20;
        invincible = false;
    }
    void Update()
    {
        if (mushyBHealth <= 0)
        {
            Destroy(gameObject);
            mushyBKilled = true;
            print("Enemy Mushy has been eliminated. Congratulations, killer.");
        }

    }

}
