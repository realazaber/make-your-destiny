using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShouldBaddyExist : MonoBehaviour 
{

	public GameObject Baddies;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Walkietalkie")
		{
			Baddies.SetActive(false);
		}
	}
}
