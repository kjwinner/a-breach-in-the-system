using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/*
The ScoreRank class keeps track of the Player's score and rank.
*/
public class ScoreRank : MonoBehaviour {
	
	public static int value = 0;//$$$ value
	public Text scoreLabel;		//UI Text showing score
	public Text rank;			//UI Text showing rank

	/*
	The Awake function makes the ScoreRank to not be destroyed and it also sets the text.
	*/
	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
		scoreLabel.text = "$$$: " + value;
		rank.text = "Rank: Newbie";
	}

	/*
	The OnLevelWasLoaded function sets the scoreLabel and rank UI Text GameObjects active
	or inactive based on the level.
	*/
	void OnLevelWasLoaded(int level)
	{
		if (level>=2 && level<=8)
		{
			if (level>2)
			{
				increment (100);
			}
			scoreLabel.gameObject.SetActive(true);
			rank.gameObject.SetActive(true);
		}
		else
		{
			scoreLabel.gameObject.SetActive(false);
			rank.gameObject.SetActive(false);
		}
	}

	/*
	The Update function updates the current $$$ value and rank.
	*/
	void Update () {
		scoreLabel.text = "$$$: " + value;
		if (value < 100) {
			rank.text = "Rank: Newbie";
		} else if (value < 500) {
			rank.text = "Rank: Novice Virus Hunter";
		} else if (value < 1000) {
			rank.text = "Rank: Omega Class Virus Tracker";
		} else if (value < 2000) {
			rank.text = "Rank: Delta Class Virus Tracker";
		} else if (value < 3500) {
			rank.text = "Rank: Gamma Class Virus Tracker";
		} else if (value < 5500) {
			rank.text = "Rank: Beta Class Virus Tracker";
		} else if (value < 8000) {
			rank.text = "Rank: Alpha Class Virus Tracker";
		} else if (value < 10000) {
			rank.text = "Rank: Gold Tier Virus Tracker";
		} else {
			rank.text = "Rank: Platinum Tier Virus Tracker";
		}
	}

	/*
	The increment function is called by other scripts and increases the $$$ value.
	*/
	public void increment (int x)
	{
		value += x;
	}
}