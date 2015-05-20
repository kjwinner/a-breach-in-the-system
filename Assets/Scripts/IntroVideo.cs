using UnityEngine;
using System.Collections;

/*
The IntroVideo class plays the intro video on a GameObject.
*/
public class IntroVideo : MonoBehaviour {

	public MovieTexture movTexture;	//the video to be played
	float timer = 0.0f;				//the timer to keep track of when to move to main menu

	/*
	The Start function retrieves the video and plays it upon instantiation.
	*/
	void Start() {
		GetComponent<Renderer>().material.mainTexture = movTexture;
		movTexture.Play();
	}

	/*
	The Update function checks to see if the alloted time for the scene has passed; if so,
	it moves to the main menu.
	*/
	void Update()
	{
		timer += Time.deltaTime;
		if (timer >21)
		{
			Application.LoadLevel(Application.loadedLevel+1);
		}
	}
}