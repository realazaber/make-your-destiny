using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCantGoBackTrigger : MonoBehaviour 
{

	public GameObject PlayerKiller;

	// Use this for initialization
	void Start () 
	{
		PlayerKiller.SetActive(false);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			PlayerKiller.SetActive(true);
		}
	}
}
