using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackDoorController : MonoBehaviour
{

    private AudioSource source;

    private bool HasPlayed = false;

	// Use this for initialization
	void Start ()
    {
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && HasPlayed == false)
        {
            source.Play();
            HasPlayed = true;

        }
    }
}
