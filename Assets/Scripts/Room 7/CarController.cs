using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour 
{

	public float CarSpeed = 0.05f;

	public bool MustMove = true;

	public GameObject Player;

	public GameObject FirstView;

	// Use this for initialization
	void Start () 
	{
		Player.SetActive(false);
		FirstView.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (MustMove == true)
		{
			transform.position = transform.position + transform.forward * CarSpeed;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "CarStopper")
		{
			Debug.Log("STOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOP");
			MustMove = false;
			Player.SetActive(true);
			FirstView.SetActive(false);
		}
	}
}
