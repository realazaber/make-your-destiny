using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGotGoodPotion : MonoBehaviour 
{

	public GameObject GudParticles;

	// Use this for initialization
	void Start () 
	{
		GudParticles.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "AmazePotion")
		{
			GudParticles.SetActive(true);
		}
	}
}
