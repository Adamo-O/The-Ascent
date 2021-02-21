using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSquidB : MonoBehaviour
{

    public Transform farEnd;
    private Vector3 frometh;
    private Vector3 untoeth;
    private float secondsForOneLength = 4.7f;

    void Start()
    {
        frometh = transform.position;
        untoeth = farEnd.position;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(frometh, untoeth, Mathf.SmoothStep(0f, 1f, Mathf.PingPong(Time.time / secondsForOneLength, 1f)));

    }
}
