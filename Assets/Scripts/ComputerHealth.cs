using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/*
The ComputerHealth script stores and updates the health of a single computer/room.
*/
public class ComputerHealth : MonoBehaviour
{
	public int startingHealth = 1000;
	public int currentHealth;
	public GameObject healthIndicator;	//the Point Light GameObject whose color changes
										//to show the health of the Computer
	
	bool isDead;
	
	/*
	The Awake function is run upon calling the script.
	It sets the currentHealth equal to the maximum Health (startingHealth) and sets
	the color of the healthIndicator to green(maximum starting health).
	*/
	void Awake ()
	{
		currentHealth = startingHealth;
		healthIndicator.GetComponent<Light>().color = new Color32 (0, 255, 0, 1);
	}
	
	/*
	The Update function updates the color of the healthIndicator Point Light.
	It calculates it by having green be full health and red be zero health.
	*/
	void Update ()
	{
		float gVal = currentHealth/3.9f/255f;
		float rVal = 1 - gVal;
		healthIndicator.GetComponent<Light>().color = new Color (rVal, gVal, 0, 1);
	}

	/*
	The TakeDamage function decreases the computer's heatlh param amount.
	It calls the Death function if the computer no longer has health.
	*/
	public void TakeDamage (int amount)
	{	
		currentHealth -= amount;	
		if(currentHealth <= 0 && !isDead)
		{
			Death ();
		}

	}
	
	/*
	The Death function changes the value of the isDead field.
	*/
	void Death ()
	{
		isDead = true;
	}
	
	/*
	The RestartLevel function restarts the current scene when all health has run out.
	*/
	public void RestartLevel ()
	{
		Application.LoadLevel (Application.loadedLevel);
	}
}
