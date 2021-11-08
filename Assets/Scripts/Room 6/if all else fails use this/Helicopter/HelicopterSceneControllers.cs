using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterSceneControllers : MonoBehaviour 
{

	public GameObject HeliLoadNextScene;

	public GameObject DestroyHeliAndActivateBaddies;

	

	// Use this for initialization
	void Start () 
	{
		HeliLoadNextScene.SetActive(false);
		DestroyHeliAndActivateBaddies.SetActive(true);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "CanGoOnHeli")
		{
			HeliLoadNextScene.SetActive(true);
			DestroyHeliAndActivateBaddies.SetActive(false);
		}
	}
}
