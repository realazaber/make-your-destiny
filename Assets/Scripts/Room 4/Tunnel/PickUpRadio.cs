using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRadio : MonoBehaviour
{

    public GameObject WalkieTalkie;

	// Use this for initialization
	void Start ()
    {
        WalkieTalkie.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "WalkieTalkiePickup")
        {
            WalkieTalkie.SetActive(true);
        }
    }
}
