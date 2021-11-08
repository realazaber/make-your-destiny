using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHelicopterContoller : MonoBehaviour 
{

	public GameObject CanGoOnHeli;
	public GameObject CanGoOnHeliWithKids;

	// Use this for initialization
	void Start () 
	{
		CanGoOnHeli.SetActive(false);	
		CanGoOnHeliWithKids.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "PlayerLetOutKids")
		{
			CanGoOnHeli.SetActive(true);
		}
		if (other.gameObject.tag == "AmazePotion")
		{
			CanGoOnHeliWithKids.SetActive(true);
		}
	}
}
