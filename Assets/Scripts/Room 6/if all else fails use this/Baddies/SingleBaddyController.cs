using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SingleBaddyController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = transform.position + transform.forward * 0.01f; 
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Destroy(GameObject.FindGameObjectWithTag("Player"));
			SceneManager.LoadScene("Died");
		}
	}
}
