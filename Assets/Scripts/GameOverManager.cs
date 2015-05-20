using UnityEngine;
using UnityEngine.UI;

/*
The GameOverManager script regulates the ending of a level in the game.
It can either be won or lost, and the script is updated in such
cases accordingly.
*/
public class GameOverManager : MonoBehaviour
{
	public Slider totalComputerHealth;
	public Slider XPSlider;	
	Animator anim;
	ScoreRank s;
	
	/*
	Upon instantiatoin the Animator component of the GUI is retrieved.
	The Animator is used later to play GUI animations upon the end of level.
	*/
	void Awake()
	{
		anim = GetComponent<Animator>();
	}
	
	/*
	The Update function calls the GameOver trigger when the game is lost and the
	LevelWon trigger when the game is won.
	The triggers will play the GUI animations when this happens.
	*/
	void Update()
	{
		if (totalComputerHealth.value <= 0)
		{
			anim.SetTrigger("GameOver");
		}
		if (XPSlider.value >= XPSlider.maxValue)
		{
			anim.SetTrigger ("LevelWon");
		}
	}
}
