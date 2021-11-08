using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeliLoadNextScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Helicopter")
		{
			SceneManager.LoadScene("7");
			Debug.Log("Triggered Triggered Triggered Triggered Triggered Triggered Triggered Triggered Triggered Triggered");	
		}
	}
}
