using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/*
The PCHealth script stores and updates the health for an entire computer system (1 big room).
*/
public class PCHealth : MonoBehaviour {

	public GameObject[] PC;					//The constituent small rooms/computers
	public Slider computerHealthSlider;		//The GUI Slider showing computer health.
	public int totalCurrentHealth;			//The sum of the total health
	
	/*
	The Update function calculates the sum of the healths of all the constituent computers, stores it as
	the current health (totalCurrentHealth), and updates the GUI Slider.
	*/
	void Update () {
		int sum = 0;
		for (int i = 0; i < PC.Length; i++)
		{
			sum += PC[i].GetComponent<ComputerHealth>().currentHealth;
		}
		totalCurrentHealth = sum;
		computerHealthSlider.value = totalCurrentHealth;
	}
}
