using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialCube : MonoBehaviour 
{
	public GameObject SpecialAction;
	private AudioSource source;

	// Use this for initialization
	void Start () 
	{
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			source.Play();
			SpecialAction.SetActive(true);

		}
	}
}
