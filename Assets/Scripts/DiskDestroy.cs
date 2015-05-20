using UnityEngine;
using System.Collections;

/*
The DiskDestroy script sets a lifetime for each Disk that is instantiated.
*/
public class DiskDestroy : MonoBehaviour {

	public float lifetime = 4.0f;

	/*
	The Awake function is called upon instantiation and destroys the disk
	the number of seconds defined in the lifetime field.
	*/
	void Awake(){
		Destroy (gameObject, lifetime);
	}
}
