using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotateDetector : MonoBehaviour
{

    public GameObject Eyes;

    public float EyeSpeed = 0.1f;

    public bool PlayerLookingAway = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (PlayerLookingAway == true)
        {
            Eyes.transform.position = Eyes.transform.position + transform.forward * EyeSpeed;
        }

        

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Gun")
        {
            PlayerLookingAway = false;
        }

        if (other.gameObject.tag == "EyeDetector")
        {
            PlayerLookingAway = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "EyeDetector")
        {
            PlayerLookingAway = true;
        }
    }
}
