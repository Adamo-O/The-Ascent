using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioControl : MonoBehaviour {
    public AudioClip clipA;
    public AudioClip clipB;
    public AudioClip clipC;
    public AudioClip clipD;
    public AudioClip clipE;
	// Use this for initialization
	void Start () {
        
        AudioSource audioSource = GetComponent<AudioSource>();
        StartCoroutine(playNextBackground());
        
	}
	
    IEnumerator playNextBackground()
    {
        //This lets us switch songs while the game is being played automatically
        if(GetComponent<AudioSource>().clip == clipA)
        {
            GetComponent<AudioSource>().PlayOneShot(clipA);
        }
        if(GetComponent<AudioSource>().isPlaying == clipA)
        {
            yield return new WaitForSeconds(clipA.length);
            GetComponent<AudioSource>().PlayOneShot(clipB);
        }
        if (GetComponent<AudioSource>().isPlaying ==  clipB)
        {
            yield return new WaitForSeconds(clipB.length);
            GetComponent<AudioSource>().PlayOneShot(clipC);
        }
        if (GetComponent<AudioSource>().isPlaying == clipC)
        {
            yield return new WaitForSeconds(clipC.length);
            GetComponent<AudioSource>().PlayOneShot(clipD);
        }
        if (GetComponent<AudioSource>().isPlaying == clipD)
        {
            yield return new WaitForSeconds(clipD.length);
            GetComponent<AudioSource>().PlayOneShot(clipE);
        }
        if (GetComponent<AudioSource>().isPlaying == clipE)
        {
            yield return new WaitForSeconds(clipE.length);
            GetComponent<AudioSource>().PlayOneShot(clipA);
        }
    }
}
