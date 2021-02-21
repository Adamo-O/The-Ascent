using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpwardsPlat : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private bool goUp;
    private bool OSHTGOBACK;
    private Vector3 posA;

    private Vector3 posB;

    private Vector3 nextPos;

    private Vector3 posBack;

    [SerializeField]
    private float speed;

    [SerializeField]
    private Transform childTransform;

    [SerializeField]
    private Transform transformB;

    [SerializeField]
    private Transform transformA;

    // Use this for initialization
    void Start()
    {
        OSHTGOBACK = false;
        goUp = false;
        posA = childTransform.localPosition;
        posB = transformB.localPosition;
        posBack = transformA.localPosition;
        nextPos = posB;
        
    }
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                OSHTGOBACK = false;
                goUp = true;
            }
        }
    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            goUp = false;
            OSHTGOBACK = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(MushyHealth.mushyKilled && MushyBHealth.mushyBKilled)
        {            
            print("Final moving plat has been unlocked.");
            if (goUp)
            {
                Move();
            }
            if (OSHTGOBACK)
            {
                GoBack();
            }
        }
        
    }
    
    private void Move()
    {
        childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, nextPos, speed * Time.deltaTime);
    }
    private void GoBack()
    {
        childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, posBack, speed * Time.deltaTime);
    }

}
