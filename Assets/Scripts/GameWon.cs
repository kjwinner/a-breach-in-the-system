using UnityEngine;
using System.Collections;
/*
The GameWon script contains the NextLevel functions, which loads the next level if the
level is won.
*/
public class GameWon : MonoBehaviour {

	/*
	The NextLevel function is called when the level is won and it loads the next level.
	*/
	public void NextLevel()
	{
		Application.LoadLevel (Application.loadedLevel+1);
	}
}
