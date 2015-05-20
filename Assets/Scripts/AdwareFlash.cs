using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/*
The AdwareFlash class controls the flashing of the "adware" caused by too many Adware viruses.
*/
public class AdwareFlash : MonoBehaviour {

	public GameObject flash;		//image to be flashed
	float updateTimer = 0.0f;		//timer until new calculation
	float flashTimer = 0.0f;		//timer until new flash
	float flashFrequency = 10.0f;	//frequency of flash
	

	/*
	The Update function increments the two timers and flashes and unflashes the "ad" if the flashTimer
	is up.

	If the updateTimer is up, the Update method will recalculate the flashFrequency.
	*/
	void Update () {
		updateTimer += Time.deltaTime;
		flashTimer += Time.deltaTime;

		if (flash.activeInHierarchy) {
			flash.SetActive(false);
			flashTimer = 0.0f;
		}
		if (flashTimer > flashFrequency)
		{
			flash.SetActive(true);
		}


		if (updateTimer>10.0f)
		{
			updateTimer = 0.0f;
			GameObject[] adwares = GameObject.FindGameObjectsWithTag("Adware") as GameObject[];
			int l = adwares.Length;
			flashFrequency = 10f/l;

			if (flashFrequency>2.0f)
			{
				flashFrequency = 2.0f;
			}

		}
	}
}
