using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWentInTrigger : MonoBehaviour 
{
	public GameObject PlayerCantGoBack;

	// Use this for initialization
	void Start () 
	{
		PlayerCantGoBack.SetActive(false);		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			PlayerCantGoBack.SetActive(true);
		}
	}
}
