using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepingPlayerIn : MonoBehaviour 
{
	public GameObject PlayerWentIn;
	public GameObject PlayerCantGoBack;

	// Use this for initialization
	void Start () 
	{
		PlayerWentIn.SetActive(true);
		PlayerCantGoBack.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
