using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanPlayerCallHelicopter : MonoBehaviour
{

    public bool CanCallHeli = false;

    public bool HeliGoDown = false;

    

    public GameObject Helicopter;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Walkietalkie")
        {
            CanCallHeli = true;
        }
    }
}
