using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/*
The DiskAttack script regulates the attack of viruses and increases the XP accordingly.
*/
public class DiskAttack : MonoBehaviour {
	
	ScoreRank s;	//script tracking the score and rank

	/*
	The Awake function retrieves the object reference for the ScoreRank s script.
	*/
	void Awake()
	{
		s = GameObject.FindGameObjectWithTag ("ScoreRankRegulator").GetComponentInChildren<ScoreRank>();
	}

	/*
	The OnTriggerEnter collider determines if the object the Disk collided into is a virus,
	and if it is it increases the XP by an amount that the Virus gives when it is destroyed.

	It also differentiates between Viruses, the Adware subset, and the Web Boss and scores accordingly.
	*/
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Virus" || other.gameObject.tag == "Adware") 
		{
			Destroy (other.gameObject);
			int points = other.GetComponent<VirusAttack>().points;
			XPManager.score += points;
			s.increment(3);
		}
		if (other.gameObject.tag == "Boss") 
		{
			WebBossHealth h = other.GetComponent <WebBossHealth> ();
			h.TakeDamage();
		}
	}
}
