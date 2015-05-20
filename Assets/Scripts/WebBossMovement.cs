using UnityEngine;
using System.Collections;

/*
The WebBossMovement script handles the WebBoss movement regarding speed and destination.
*/
public class WebBossMovement : MonoBehaviour
{
	public Transform goTo;	//Transform variable that holds the coordinates, rotation, and scale of the object.
	NavMeshAgent nav;		//NavMeshAgent of WebBoss object
	
	/*
	The Awake function sets the transform goTo and retrieves the NavMeshAgent component
	and sets the destination of the NavMeshAgent.
	*/
	void Awake ()
	{
		nav = GetComponent <NavMeshAgent> ();
		nav.SetDestination (goTo.position);
	}


}
