using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDieWorldDie : MonoBehaviour 
{
	public GameObject WorldKiller;
	
	void Update()
	{
		WorldKiller.SetActive(true);
		WorldKiller.transform.position = transform.position + transform.forward * 50;
	}
}
