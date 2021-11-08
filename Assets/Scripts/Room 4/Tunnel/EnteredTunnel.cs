using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnteredTunnel : MonoBehaviour
{
    public GameObject ExitTunnel;
	// Use this for initialization
	void Start ()
    {
        ExitTunnel.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ExitTunnel.SetActive(true);
        }
    }
}
