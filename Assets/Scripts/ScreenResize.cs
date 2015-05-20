using UnityEngine;
using System.Collections;

/*
The ScreenResize script sets and adjusts the "screen" on which the Intro video is shown
at the start of the game.
*/
public class ScreenResize : MonoBehaviour {

	/*
	The Start function sets the scale of the cube GameObject on which the video 
	is displayed by calculating the aspect ratio.
	*/
	void Start () {
		float aspectRatio = (float)Screen.width / Screen.height;
		transform.localScale = new Vector3(aspectRatio, 1, 0.1f);
	}
	
	/*
	The Update function continuously updates the scale of the cube GameObject on which the
	video is displayed by calculating the aspect ratio.
	*/
	void Update () {
		float aspectRatio = 0.95f * (float)Screen.width / Screen.height;
		transform.localScale = new Vector3(aspectRatio, 1, 0.1f);
	}
}
