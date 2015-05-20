using UnityEngine;
using System.Collections;

/*
The PlayerShooting script regulates the shooting of the Disk by the player.
*/
public class PlayerShooting : MonoBehaviour {
	
	public Rigidbody disk;	//the Disk prefab that is shot
	
	/*
	The Update function shoots a Disk prefab when the Fire1 input is button downed and the game
	is not paused.
	*/
	void Update () {
		if (Input.GetButtonDown ("Fire1") && Time.timeScale == 1.0) 
		{			
			Rigidbody instantiatedDisk = Instantiate (disk, transform.position, transform.rotation)
				as Rigidbody;
			instantiatedDisk.velocity = transform.TransformDirection(new Vector3(0,0,50f));
		}
	}
}
