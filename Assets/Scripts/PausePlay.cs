using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/*
The PausePlay script regulates the pausing and playing of music in the build.
*/
public class PausePlay : MonoBehaviour {

	public Button pButton;			//the Pause button
	public Image pauseBackground;	//the background Image when the pause button is pressed
	public Button mainMenu;
	public Button music;
	public Button exit;

	bool play;

	/*
	Upon instantiation, the Start function ensures that the scene is not paused upon loading.
	*/
	void Start () 
	{
		Time.timeScale = 1.0f;
		play = true;
	}

	/*
	The Update function also allows for an a pause key to achieve the same effect as clicking
	the Pause button.
	*/
	void Update()
	{
		if (Input.GetButtonDown ("Cancel") || Input.GetButtonDown("PausePlay"))
		{
			Clicked ();
		}
	}
	
	/*
	The Clicked function pauses or plays the game.
	It shows the pause background, main menu button and music on/off button on pause.
	It removes sets them inactive on play.
	*/
	public void Clicked()
	{
		if (play)
		{
			Time.timeScale = 0.0f;
			play = false;
			pButton.GetComponentInChildren<Text>().text = "►";
			pButton.GetComponentInChildren<Text>().fontSize = 45;
			mainMenu.gameObject.SetActive(true);
			music.gameObject.SetActive(true);
			exit.gameObject.SetActive (true);
			pauseBackground.gameObject.SetActive(true);

		}
		else
		{
			Time.timeScale = 1.0f;
			play = true;
			pButton.GetComponentInChildren<Text>().text = "▋▋";
			pButton.GetComponentInChildren<Text>().fontSize = 35;
			mainMenu.gameObject.SetActive(false);
			music.gameObject.SetActive(false);
			exit.gameObject.SetActive(false);
			pauseBackground.gameObject.SetActive(false);
		}
	}
}
