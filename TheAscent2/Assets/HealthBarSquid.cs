using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets._2D;
using UnityEngine.SceneManagement;

public class HealthBarSquid : MonoBehaviour
{
    private float mHealth = 100f;
    private float curHealth = 0f;
    public Image image;
    public GameObject healthBar;
    // Use this for initialization
    void Start()
    {
        curHealth = mHealth;
        InvokeRepeating("decreaseHealth", 1f, 1f);
        if (image == null)
        {
            image = GetComponent<Image>();
        }

    }
    void Update()
    {
        mHealth = 100;
        curHealth = SquidHealth.squidAHealth;
        transform.localScale = new Vector3((curHealth / mHealth), 1, 1);
    }
    void SetHealthVisual(float healthNormalized)
    {
        healthBar.transform.localScale = new Vector3(healthNormalized, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }
    void decreaseHealth()
    {
        curHealth -= 10f;
    }
}
