using UnityEngine;

/*
The VirusManager script regulates the spawning of the Virus objects during gameplay.
*/
public class VirusManager : MonoBehaviour
{

	public GameObject virus;		//The virus prefab to spawn
	public float spawnTime = 10f;	//The time interval between spawns
	public Transform spawnPoint;	//The transform (location) where the virus will spawn
	
	/*
	On instantiation, the script calls the Spawn function to spawn the virus objects
	at the spawn point at an interval defined by spawnTime;
	*/
	void Start ()
	{
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	
	/*
	The Spawn function spawns the virus object at the spawnPoint
	*/
	void Spawn ()
	{
		Instantiate (virus, spawnPoint.position, spawnPoint.rotation);
	}
}
