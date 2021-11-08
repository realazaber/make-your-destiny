using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActivator : MonoBehaviour 
{
	public GameObject NextButton;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Bullet")
		{
			NextButton.SetActive(true);
		}
	}
}
