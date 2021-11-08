using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayerLetKidsOut : MonoBehaviour 
{
	public GameObject PlayerLetOutKids;

	// Use this for initialization
	void Start () 
	{
		PlayerLetOutKids.SetActive(false);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Kid")
		{
			PlayerLetOutKids.SetActive(true);
		}
	}
}
