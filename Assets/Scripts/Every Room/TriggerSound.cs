using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    private AudioSource source;

    private bool IsTriggered = false;

	// Use this for initialization
	void Start ()
    {
        source = GetComponent<AudioSource>();	
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && IsTriggered == false)
        {
            source.Play();
            IsTriggered = true;
        }
    }
}
