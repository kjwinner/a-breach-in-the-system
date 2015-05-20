using UnityEngine;
using System.Collections;

/*
The ScoreRankCanvas class ensures that the GameObject will not be destroyed on load.
*/
public class ScoreRankCanvas : MonoBehaviour {
	/*
	The Awake function ensures that the GameObject will not be destroyed on load.
	*/
	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}
}
