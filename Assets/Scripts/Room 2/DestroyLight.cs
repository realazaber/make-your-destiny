using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLight : MonoBehaviour
{

    public GameObject OnLight;

    public GameObject OffLight;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Baddy")
        {
            Debug.Log("COLLIDED COLLIDED COLLIDED COLLIDED");
            OnLight.SetActive(false);
            OffLight.SetActive(true);
        }
    }
}
