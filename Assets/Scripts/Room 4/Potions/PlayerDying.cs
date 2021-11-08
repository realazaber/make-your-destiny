using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDying : MonoBehaviour 
{
	public GameObject PlayerBleeding;
	public GameObject PlayerKiller;

	// Use this for initialization
	void Start () 
	{
		PlayerBleeding.SetActive(false);		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "KillPlayer")
		{
			PlayerBleeding.SetActive(true);
			PlayerKiller.SetActive(true);
		}
	}
}
