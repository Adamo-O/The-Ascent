using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attac : MonoBehaviour {
    //Attacking classes and variables
    private bool attacking = false;
    private float attacTimer = 0f;
    [SerializeField]
    public float attacCd = 0.1f;
    public Collider2D attacTrigger;
    private Animator anim;
    //Cooldown classes and variables
    private bool coolingDown = false;            //Checks if attack is cooling down
    public float cooldownTime = 0;           //How long the cooldown has been going on for
    public float timeRequired = 1f;           //Length of cooldown total

    void Awake()
    {
        anim = GetComponent<Animator>();
        attacTrigger.enabled = false;
    }

    void Update()
    {
        
        if (coolingDown)
        {
            
            cooldownTime += Time.deltaTime;
            if (cooldownTime >= timeRequired)
            {
                coolingDown = false;
                cooldownTime = 0;
            }
        }
        if (Input.GetButtonDown("Attac"))
        {

            if (anim.GetBool("Ground") == false)
            {
                return;
            }
            attacking = true;
            attacTimer = attacCd;
            attacTrigger.enabled = true;

            anim.SetBool("Attac", attacking);
        }

        if (attacking)
        {
            if (attacTimer > 0)
            {
                attacTimer -= Time.deltaTime;
            }
            else
            {
                attacking = false;
                attacTrigger.enabled = false;
                anim.SetBool("Attac", false);
                coolingDown = true;

            }
        }

        //anim.SetBool("Attac", attacking);
        if (Input.GetButtonUp ("Attac"))
        {
            
            coolingDown = true;
            
        }
    }

}
