using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/*
The PlayMovie class plays a video in the UI.
*/
public class PlayMovie : MonoBehaviour {

	/*
	The Start function, called at instantiation, plays the video.
	*/	
	float timer = 0.0f;

	void Start () {
		(GetComponent<RawImage>().mainTexture as MovieTexture).Play(); 
	}
}