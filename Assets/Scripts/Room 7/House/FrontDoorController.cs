using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontDoorController : MonoBehaviour 
{

	public GameObject Door;

	public float RotationOfDoor = 0f;

	public bool PlayerInTriggerOfDoor = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (PlayerInTriggerOfDoor == true)
		{
			RotationOfDoor = RotationOfDoor + 0.1f;
			
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			PlayerInTriggerOfDoor = true;
		}
	}
}
