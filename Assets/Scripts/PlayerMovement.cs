using UnityEngine;
using System.Collections;

/* 
The PlayerMovement script regulates the player character's movement.
*/
public class PlayerMovement : MonoBehaviour {

	

	/*
	The Awake function calls the DontDestroyOnLoad function to allow the Player to be the same throughout scenes.
	*/
	void Awake()
	{
		DontDestroyOnLoad (transform.gameObject);
	}
		
	/*
	The OnLevelWasLoaded function ensures that the Player is respawned in the correct location at the beginning of each level.
	*/
	void OnLevelWasLoaded(int level)
	{
		if (level == 2) {transform.position = new Vector3(52,54,9);	transform.rotation = new Quaternion(0f,1f,0f,0f);}
		if (level == 3) {transform.position = new Vector3(-19,54,9);	transform.rotation = new Quaternion(0f,0f,0f,1f);}
		if (level == 4) {transform.position = new Vector3(52,54,-203);	transform.rotation = new Quaternion(0f,1f,0f,0f);}
		if (level == 5) {transform.position = new Vector3(-19,54,-203);	transform.rotation = new Quaternion(0f,0f,0f,1f);}
		if (level == 6) {transform.position = new Vector3(52,54,-412);	transform.rotation = new Quaternion(0f,1f,0f,0f);}
		if (level == 7) {transform.position = new Vector3(-19,54,-412);	transform.rotation = new Quaternion(0f,0f,0f,1f);}
		if (level == 8) {transform.position = new Vector3(24,54,18);	transform.rotation = new Quaternion(0f,0.7f,0f,-0.7f);}
	}
	
	/*
	The FixedUpdate function determines a rotation and forward/backward movement
	based on the horizontal and vertical inputs.
	It animates the player character accordingly, by whether it is moving or is
	idle/rotating.
	*/
	void FixedUpdate() {
		float horizontal = Input.GetAxis("Horizontal") * 1.5f;
		transform.Rotate(new Vector3(0, horizontal, 0));

		if (horizontal == 0)
		{
			transform.Rotate (new Vector3(0,0,0));
		}
		
		float vertical = Input.GetAxis ("Vertical") * 0.8f;
		GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection (new Vector3 (-vertical, 0, 0)));

		if (!GetComponent<Animation>().IsPlaying("punch_hi_left")){
			if (vertical!=0)
			{

				GetComponent<Animation>().Play ("loop_run_funny");
				GetComponent<Animation>()["loop_run_funny"].speed = 2.0f;

			}
			else
			{
				GetComponent<Animation>().Play ("loop_idle");
			}
		
			if (Input.GetAxisRaw ("Fire1") == 1) 
			{
				
				GetComponent<Animation>().Play ("punch_hi_left");
				GetComponent<Animation>()["punch_hi_left"].speed = 2.0f;
			}
	
		}
		Debug.Log (transform.rotation);
	}
}