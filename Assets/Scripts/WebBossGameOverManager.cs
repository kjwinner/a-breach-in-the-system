using UnityEngine;
using System.Collections;

/*
The WebBossGameOverManager regulates the ending of the final level which includes
the WebBoss virus.
*/
public class WebBossGameOverManager : MonoBehaviour {

	Animator anim;

	/*
	The Awake function retrieves the Animator component of the UI Canvas to which
	this script is a component of.
	*/
	void Awake()
	{
		anim = GetComponent<Animator>();
	}

	/*
	The GameLost function, when called, sets the trigger for the animation which
	plays the GameOver animation.
	*/
	public void GameLost()
	{
		anim.SetTrigger("GameOver");
	}

	/*
	The GameWon function, when called, sets the trigger for the animation which
	plays the GameWon animation.
	*/
	public void GameWon()
	{
		anim.SetTrigger ("LevelWon");
	}
}