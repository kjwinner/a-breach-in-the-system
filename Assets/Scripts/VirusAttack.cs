using UnityEngine;
using System.Collections;
/*
The VirusAttack script regulates the attacking of a Virus object.
*/
public class VirusAttack : MonoBehaviour
{
	public float timeBetweenAttacks = 2.5f;	//The cooldown time between attacks
	public int attackDamage = 10;			//The damage dealt to a computer marker
	public int points;						//Number points gained by killing this Virus object
	
	public string attack;					//Which computer marker to attack
	GameObject computer;					//Which computer the computer with the marker is
	ComputerHealth computerHealth;			//The health of computer object
	bool computerInRange;					//Boolean value of whether the computer can be attacked given range
	float timer;							//Timer which regulates time between attacks
	
	/*
	The Awake function finds the computer with the tag passed in as an argument in the inspector.
	Its ComputerHealth script is also retrieved.
	*/
	void Awake ()
	{
		computer = GameObject.FindGameObjectWithTag (attack);
		computerHealth = computer.GetComponent <ComputerHealth> ();
	}
	
	/*
	The OnTriggerEnter method determines whether the computer to attack is within range.
	IT updates the computerInRange field appropriately.
	*/
	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject == computer)
		{
			computerInRange = true;
		}
	}
	
	/*
	The OnTriggerExit method determines whether the computer to attack is left range.
	IT updates the computerInRange field appropriately.
	*/
	void OnTriggerExit (Collider other)
	{
		if(other.gameObject == computer)
		{
			computerInRange = false;
		}
	}
	
	/*
	The Update function makes sure that enough time has passed before a previous attack, the
	computer to attack is within range, and it is not dead before attacking it by calling
	the Attack function.
	*/
	void Update ()
	{
		timer += Time.deltaTime;
		
		if(timer >= timeBetweenAttacks && computerInRange && computerHealth.currentHealth > 0)
		{
			Attack ();
		}
	}
	
	/*
	The Attack function resets the timer and deals damage to the computer.
	*/
	void Attack ()
	{
		timer = 0f;
		computerHealth.TakeDamage (attackDamage);
	}

}
