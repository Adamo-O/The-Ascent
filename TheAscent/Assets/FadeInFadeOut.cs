using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInFadeOut : MonoBehaviour {
   public static FadeInFadeOut Instance { set; get; }
    bool doFade = FinalPlat.fadeNow;
    public Image fadeImage;
    private bool isInTransition;
    private float transition;
    private bool isShowing;
    private float duration;
    public float fadeWaitTime = 0.0f;
    private bool fadeOut;

    public Camera mainCamera;
    public GameObject player;
    public Animator demonTrans;

    private void Awake()
    {
        Instance = this;
    }

    public void Fade(bool showing, float duration)
    {
        isShowing = showing;
        isInTransition = true;
        this.duration = duration;
        transition = (isShowing) ? 0 : 1;
    }
    

    private void Update()
    {
        
        if (FinalPlat.fadeNow == true)
        {
            Fade(true, 3.25f);
            isInTransition = false;
            Fade(false, 3.0f);
            //Only fades in with this code
            Fade(true, 3.25f);
            print("Fade is over.");
            FinalPlat.fadeNow = false;
            fadeOut = true;
            StartCoroutine(Wait());
        }
        

        if (!isInTransition)
        {
            return;
        }
        transition += (isShowing) ? Time.deltaTime * (1 / duration) : -Time.deltaTime * (1 / duration);
        fadeImage.color = Color.Lerp(new Color(1, 1, 1, 0), Color.white, transition);

        if(transition > 1 || transition < 0)
        {
            isInTransition = false;
        }
    }
    IEnumerator Wait()
    {
        
        //
        yield return new WaitForSeconds(fadeWaitTime);
        print("Done waiting.");
        Destroy(player);
        print("Player has been destroyed.");
        mainCamera.transform.position = new Vector3(331.1f, 96.1f, -10);
        print("Camera has been moved.");
        mainCamera.orthographicSize = 45;
        print("Camera size has changed.");
        Fade(false, 3.0f);
        print("Second Fade is over.");
        demonTrans.SetBool("StartAnimation", true);
        FinalPlat.fadeNow = false;
        TextChanger.startChanging = true;
        yield break;
    }

}
