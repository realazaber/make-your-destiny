using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingOnTheHeli : MonoBehaviour 
{

	public GameObject PlayerOnHeliPoisiton;

	public GameObject PlayerOnHeliText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (PlayerOnHeliText.activeSelf == true && Input.GetKeyDown(KeyCode.Mouse1))
		{
			
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			PlayerOnHeliText.SetActive(true);
		}
	}
}
