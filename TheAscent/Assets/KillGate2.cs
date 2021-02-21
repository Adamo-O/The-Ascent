using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillGate2 : MonoBehaviour
{
    void Update()
    {
        if (SquidHealth.squidKilled && SquidBHealth.squidBKilled == true)
        {
            Destroy(gameObject);
        }
    }
}
