using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDyingFromPotion : MonoBehaviour 
{

	public GameObject SeeingDeath;
	public GameObject DeathParticles;
	public float SpeedOfDeath = 0.1f;
	
	// Update is called once per frame
	void Update () 
	{
		if (DeathParticles.activeSelf == true)
		{			
			SeeingDeath.transform.position = SeeingDeath.transform.position + -transform.forward * (SpeedOfDeath / 4); 
		}	
	}
}
