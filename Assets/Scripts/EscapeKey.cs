using UnityEngine;
using System.Collections;

/*
The EscapeKey script regulates the closing of the application
by pressing an escape key.
*/
public class EscapeKey : MonoBehaviour {

	/*
	The Update function defines that when a predefined escape key is
	pressed, the application quits.
	*/
	void Update () {
		if (Input.GetButtonDown("Cancel"))
		{
			Application.Quit();
		}
	}
}
