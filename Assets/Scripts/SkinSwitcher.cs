using UnityEngine;
using System.Collections;

/*
The SkinSwitcher class allows the user to change skins and customize the virus tracker.
*/
public class SkinSwitcher : MonoBehaviour {
	public Texture[] texture;	//array of skins
	public GameObject[] obj;	//array of GameObject objects to be retextured
	int textureIndex = 0;		//location in texture

	/*
	The setIndex function is called by the SwitchImage script to choose the new skin.
	*/
	public void setIndex(int currentIndex)
	{
		textureIndex = currentIndex;
	}

	/*
	The getIndex function returns the index of the current skin.
	*/
	public int getIndex()
	{
		return textureIndex;
	}

	/*
	The OnLevelWasLoaded function retextures the Player when a new level is loaded.
	*/
	void OnLevelWasLoaded(int level)
	{
		for (int i = 0; i < obj.Length; i++)
		{
			obj[i].GetComponent<Renderer>().material.mainTexture = texture[textureIndex];
		}
	}
}
