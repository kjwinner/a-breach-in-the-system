using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/*
The SwitchImage class switches images of different skins on the VirusTracker.
*/
public class SwitchImage : MonoBehaviour {

	public Sprite[] skins;		//UI Sprite images of the skins
	int currentIndex;			//the current image in skins
	SkinSwitcher skinSwitcher;	//SkinSwitcher script which applies the retexturing

	/*
	The Awake function retrieves the SkinSwitcher and gets the current index and sets the image accordingly.
	*/
	void Awake()
	{
		skinSwitcher = GameObject.FindGameObjectWithTag ("Player").GetComponent<SkinSwitcher>();
		currentIndex = skinSwitcher.getIndex ();
		Set ();
	}

	/*
	The Left function goes to the previous image when the left button is pressed.
	*/
	public void Left()
	{
		currentIndex = (currentIndex + skins.Length - 1) % (skins.Length);
		Set ();
	}

	/*
	The Right function goes to the previous image when the right button is pressed.
	*/
	public void Right()
	{
		currentIndex = (currentIndex + 1) % (skins.Length);
		Set ();
	}

	/*
	The Set function sets the image according to the currentIndex.
	*/
	void Set()
	{
		gameObject.GetComponent<Image>().sprite = skins [currentIndex];
		skinSwitcher.setIndex (currentIndex);

	}

		
}

