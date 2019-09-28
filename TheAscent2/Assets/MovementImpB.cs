using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementImpB : MonoBehaviour
{

    public Transform farEnd;
    private Vector3 frometh;
    private Vector3 untoeth;
    private float secondsForOneLength = 6f;

    public Transform player;
    [SerializeField]
    public float speed = 0.75f;

    //int MinDist = 3;

    void Start()
    {
        frometh = transform.position;
        untoeth = farEnd.position;
    }

    void Update()
    {
       
            transform.position = Vector3.Lerp(frometh, untoeth, Mathf.SmoothStep(0f, 1f, Mathf.PingPong(Time.time / secondsForOneLength, 1f)));

        //ADD Chasing script here!!

    }
    
}
