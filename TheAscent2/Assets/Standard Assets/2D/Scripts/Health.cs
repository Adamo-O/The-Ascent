/*
using System.Collections.Generic;*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
/*using UnityStandardAssets._2D;
using UnityEngine.SceneManagement; */

public class Health : MonoBehaviour
{
    
    public const int maxHealth = 100;
    public static int currentHealth = 100;
    public int damage = 10;
    public Canvas HealthbarCanvasNew;
    public Image GreenForeground;
    public GameObject Respawner;
    public Transform respawnPoint;
    public GameObject player;
    public int foodRestoreAmountOne = 10;
    public int foodRestoreAmountTwo = 30;
    private bool invincible = false;

    [SerializeField]
    public float damageRefreshRate = 0.6f;
    

    void Awake()
    {
        currentHealth = maxHealth;
        player = GameObject.Find("CharacterRobotBoy");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
            //Checks for enemy tag on collision
            if (collision.gameObject.tag == "Enemy")
            {
                if (!invincible)
                {
                ApplyDamage();
                }
                
            }
        if (collision.gameObject.tag == "SquidA")
        {
            if (!invincible)
            {
                print("Player was hit by Squid A");
                ApplyDamage();
            }
        }
        if (collision.gameObject.tag == "SquidB")
        {
            if(!invincible)
            {
                print("Player was hit by Squid B");
                ApplyDamage();
            }
        }
        
        //Checks if player jumps off the map
        if (collision.gameObject.tag == "DeathBarrier")
        {
            print("Mistakes were made.");
            Death();
        }

        //FOOD
        //if character is already at maxhealth then dont gain any health
        if (currentHealth >= maxHealth)
        {
            return;
        }
        else
        {
            //if character is already at maxhealth then dont gain any health
            if (currentHealth >= maxHealth)
            {
                return;
            }
            else
            {
                if (collision.gameObject.tag == "FoodOne")
                {
                    if (currentHealth + foodRestoreAmountOne > maxHealth)
                    {
                        currentHealth = 100;
                        Destroy(collision.gameObject);
                    }
                    else
                    {
                        currentHealth += foodRestoreAmountOne;
                        Destroy(collision.gameObject);
                    }
                }
                if (collision.gameObject.tag == "FoodTwo")
                {
                    if (currentHealth + foodRestoreAmountTwo > maxHealth)
                    {
                        currentHealth = 100;
                        Destroy(collision.gameObject);
                    }
                    else
                    {
                        currentHealth += foodRestoreAmountTwo;
                        Destroy(collision.gameObject);
                    }
                }
                
            }
            
        }
        
        
    }
    void Update()
    {
        
        print(currentHealth);
        if (currentHealth <= 0)
        {
            Death();
        }

    }
    void ApplyDamage()
    {
        currentHealth -= damage;
        print("Player just got hit by an enemy oh no!");
        
        StartCoroutine(Wait());
        
    }
    IEnumerator Wait()
    {
        invincible = true;
        damage = 0;
        Debug.Log("Before waiting " + damageRefreshRate + " seconds");
        yield return new WaitForSeconds(damageRefreshRate);
        Debug.Log("After waiting " + damageRefreshRate + " seconds");
        damage = 10;
        invincible = false;

    }
    void Death()
    {
        print("You died.");
        gameObject.transform.position = Respawner.transform.position;
        currentHealth = maxHealth;
    }
}