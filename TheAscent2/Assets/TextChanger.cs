using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour {
    Text ending;
    bool changeActive;
    public static bool startChanging;
	// Use this for initialization
	void Start () {
        ending = GetComponent<Text>();
        changeActive = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(startChanging == true)
        {
            if(changeActive == false)
            {
                StartCoroutine(TextChangeNow());
                changeActive = true;
            } else
            {
                return;
            }
        }
	}

    IEnumerator TextChangeNow()
    {
        ending.text = "Ah, how great it feels to be my real self again.";
        yield return new WaitForSeconds(5.0f);
        ending.text = "Humans are so easy to steer in the wrong direction.";
        yield return new WaitForSeconds(5.0f);
        ending.text = "You see; everything you've done has been planned by me since the beginning.";
        yield return new WaitForSeconds(5.0f);
        ending.text = "All the innocent lives taken, the fear, the destruction-everything.";
        yield return new WaitForSeconds(5.0f);
        ending.text = "You were blindly following the norms of a game.";
        yield return new WaitForSeconds(4.0f);
        ending.text = "You didn't think for a second about the lives of others.";
        yield return new WaitForSeconds(5.0f);
        ending.text = "Now imagine, this was just a video game and look at how much chaos you caused.";
        yield return new WaitForSeconds(5.0f);
        ending.text = "Imagine how your blind decisions can be affecting your real life.";
        yield return new WaitForSeconds(5.0f);
        ending.text = "I should congratulate you, you monster.";
        yield return new WaitForSeconds(5.0f);
        Application.Quit();
    }

 }
