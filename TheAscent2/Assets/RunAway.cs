using UnityEngine;
using System.Collections;

public class RunAway : MonoBehaviour
{
    public Transform movePos;
    [SerializeField]
    public float speed = 2;
    public GameObject Mushy;

    void OnTriggerEnter2D(Collider2D col)
    {
        if ((col.isTrigger != true && col.CompareTag("Player")))
        {
            
                Mushy.transform.position = Vector3.Lerp(Mushy.transform.position, movePos.position, Time.deltaTime * speed);
            
            
        }
        
    }
   
   
}
