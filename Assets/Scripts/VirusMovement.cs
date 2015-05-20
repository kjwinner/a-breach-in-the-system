using UnityEngine;
using System.Collections;

/*
The VirusMovement script handles the Virus movement regarding speed and destination.
*/
public class VirusMovement : MonoBehaviour
{
	public string target;	//String variable that holds an object's name
	Transform goTo;			//Transform variable that holds the coordinates, rotation, and scale of the object.
	NavMeshAgent nav;		//NavMeshAgent of Virus object
	
	/*
	The Awake function sets the transform goTo and retrieves the NavMeshAgent component
	and sets the destination of the NavMeshAgent.
	*/
	void Awake ()
	{
		goTo = GameObject.FindGameObjectWithTag(target).transform;
		nav = GetComponent <NavMeshAgent> ();
		nav.SetDestination (goTo.position);
	}


}
