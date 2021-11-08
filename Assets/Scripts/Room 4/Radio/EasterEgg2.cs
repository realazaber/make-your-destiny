﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEgg2 : MonoBehaviour 
{

	private AudioSource source;

	// Use this for initialization
	void Start () 
	{
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Bullet")
		{
			source.Play();
		}
	}
}
