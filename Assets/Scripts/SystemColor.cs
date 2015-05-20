using UnityEngine;
using System.Collections;

/*
The SystemColor script regulates the System32 light health indicator at the center of each big room.
It is green when the health of the small rooms of the big room are full, and red when they are zero.
*/
public class SystemColor : MonoBehaviour {
	
	public GameObject PC1;	//These are the computer markers of the 4 constituent small rooms
	public GameObject PC2;	//--
	public GameObject PC3;	//--
	public GameObject PC4;	//--
	
	public GameObject SystemLight;	//The Point Light which is the health indicator for the big room.
	
	float health;	//the total health of the 4 constituent small rooms.

	/*
	The Start function, upon instantiation, calculates the health by calling the CalculateScore method
	and sets the SystemLight object's color to green, which is as it should be, being full in health.
	*/
	void Start () 
	{
		health = CalculateScore ();
		SystemLight.GetComponent<Light>().color = new Color32 (0, 255, 0, 1);
	}
	
	/*
	The Update function calculates the current heatlh of the 4 constituent rooms.
	Then it calculates the proper green and red values for the SystemLight based on the current health.
	*/
	void Update () 
	{
		health = CalculateScore ();
		float gVal = health/15.68f/255f;
		float rVal = 1-gVal;
		SystemLight.GetComponent<Light>().color = new Color (rVal, gVal, 0, 1);
		
	}
	
	/*
	The CalculateScore function calculates the current health of all 4 constituent small rooms and returns the total.
	It is called to calculate the color value of the SystemLight object.
	*/
	private int CalculateScore()
	{
		return PC1.GetComponent<ComputerHealth>().currentHealth +
				PC2.GetComponent<ComputerHealth>().currentHealth +
				PC3.GetComponent<ComputerHealth>().currentHealth +
				PC4.GetComponent<ComputerHealth>().currentHealth;
	}
}
