using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/*
The PreventGoThroughWalls script regulates what happens when the player goes through
the wall and falls outside of the network.
*/
public class PreventGoThroughWalls : MonoBehaviour {
	
	public Image a;	//The background UI Image to be shown when the player falls
	public Text b;	//The UI Text to be shown when the player falls

	bool timerStarted;	//boolean value starts after player falls
	float timer = 0.0f;	//value of the timer
	
	/*
	The Update function counts the time after the player triggers the trigger on the
	safety net.  After five seconds the text disappears and two seconds after the 
	text disappears the level restarts.
	*/
	void Update()
	{
		if (timerStarted)
		{
			timer += Time.deltaTime;
		}

		if (timer >= 5.0f)
		{
			b.gameObject.SetActive(false);
		}

		if (timer >= 7.0f)
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}

	/*
	The OnTriggerEnter function defines what happens when the player falls out and
	triggers the trigger.  It sets the UI Image a and UI Text b as active and starts
	the timer.
	*/
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			a.gameObject.SetActive(true);
			b.gameObject.SetActive(true);
			timerStarted = true;
		}
	}
}
