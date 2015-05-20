using UnityEngine;
using System.Collections;

/*
The ButtonScript script holds a collection of functions which load scenes.
The functions are called when the buttons which call them through their
OnClick function are pressed.
*/
public class ButtonScript : MonoBehaviour {

	/*
	The MainMenu function opens the MainMenu scene when the button which calls
	it through the OnClick function is pressed.
	*/
	public void MainMenu()
	{
		Application.LoadLevel ("MainMenu");
	}

	/*
	The Play function opens the First level scene when the button which calls
	it through the OnClick function is pressed.
	*/
		public void Play()
	{
		Application.LoadLevel ("Level1");
	}
	
	/*
	The Options function opens the Options scene when the button which calls
	it through the OnClick function is pressed.
	*/
	public void Options()
	{
		Application.LoadLevel ("Options");
	}
	
	/*
	The Instructions function opens the Instructions scene when the button which calls
	it through the OnClick function is pressed.
	*/
	public void Instructions()
	{
		Application.LoadLevel ("Instructions");
	}
	
	/*
	The Viruses function opens the first Viruses scene when the button which calls
	it through the OnClick function is pressed.
	*/
	public void Viruses()
	{
		Application.LoadLevel ("Viruses");
	}
	
	/*
	The Viruses2 function opens the second Viruses scene when the button which calls
	it through the OnClick function is pressed.
	*/
	public void Viruses2()
	{
		Application.LoadLevel ("Viruses2");
	}
	
	/*
	The Viruses3 function opens the third Viruses scene when the button which calls
	it through the OnClick function is pressed.
	*/
	public void Viruses3()
	{
		Application.LoadLevel ("Viruses3");
	}
	
	/*
	The About function opens the About scene when the button which calls
	it through the OnClick function is pressed.
	*/
	public void About()
	{
		Application.LoadLevel ("About");
	}
	
	/*
	The Exit function exits the application when the button which calls
	it through the OnClick function is pressed.
	*/
	public void Exit()
	{
		Application.Quit();
	}
	
	/*
	The Restart function reloads the current scene when the button which calls
	it through the OnClick function is pressed.
	*/
	public void Restart()
	{
		Application.LoadLevel (Application.loadedLevel);
	}
}
