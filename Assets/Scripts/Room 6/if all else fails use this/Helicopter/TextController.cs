using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour 
{

	public GameObject PlayerGetOnHeliText;

	// Use this for initialization
	void Start () 
	{
		PlayerGetOnHeliText.SetActive(false);	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "CanGoOnHeli")
		{
			PlayerGetOnHeliText.SetActive(true);
		}
	}
}
