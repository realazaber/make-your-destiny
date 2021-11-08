using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGetOnHeli : MonoBehaviour 
{

	public GameObject Text;

	public GameObject CameraOnHeli;

	// Use this for initialization
	void Start () 
	{
		CameraOnHeli.SetActive(false);	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Text.activeSelf == true && Input.GetKeyDown(KeyCode.Mouse1)) //load next scene
		{
			Destroy(GameObject.FindGameObjectWithTag("Player"));
			CameraOnHeli.SetActive(true);
			Text.SetActive(false);
			//yield WaitForSeconds(10);
			SceneManager.LoadScene("7");

		}	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "CanGoOnHeli")
		{
			Text.SetActive(true);
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "CanGoOnHeli")
		{
			Text.SetActive(false);
		}
	}
}
