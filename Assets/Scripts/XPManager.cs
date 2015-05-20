using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/*
The XPManager manages the keeping track of XP (experience points), represented
with the XP Slider located near the bottom of hte screen, during a level of gameplay.
It is referenced in other scripts to update the score.
*/
public class XPManager : MonoBehaviour
{
	public static int score;	//The int value score to store the XP, updated directly by other scripts
	public Slider XPSlider;		//The GUI Slider which shows the current XP, refers to the horizontal GUI
								// slider displaying the relative amount of XP.
	
	/*
	The Awake function runs upon calling the script and sets the starting score to 0.
	*/
	void Awake ()
	{
		score = 0;
		
	}
	
	/*
	The Update function udpates the value of XPSlider to show the value of the current
	*/
	void Update ()
	{
		XPSlider.value = score;
	}
}
